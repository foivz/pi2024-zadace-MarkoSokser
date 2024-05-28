﻿using System;
using System.Windows.Forms;

public class CalendarColumn : DataGridViewColumn
{
    public CalendarColumn() : base(new CalendarCell())
    {
    }

    public override DataGridViewCell CellTemplate
    {
        get
        {
            return base.CellTemplate;
        }
        set
        {
            if (value != null && !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
            {
                throw new InvalidCastException("Mora biti instanca CalendarCell");
            }
            base.CellTemplate = value;
        }
    }
}

public class CalendarCell : DataGridViewTextBoxCell
{
    public CalendarCell() : base()
    {
        this.Style.Format = "d"; // Postavlja format prikaza datuma
    }

    public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
    {
        base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
        CalendarEditingControl ctl = DataGridView.EditingControl as CalendarEditingControl;
        if (this.Value == null || this.Value == DBNull.Value)
        {
            ctl.Value = (DateTime)this.DefaultNewRowValue;
        }
        else
        {
            ctl.Value = (DateTime)this.Value;
        }
    }

    public override Type EditType
    {
        get
        {
            return typeof(CalendarEditingControl);
        }
    }

    public override Type ValueType
    {
        get
        {
            return typeof(DateTime);
        }
    }

    public override object DefaultNewRowValue
    {
        get
        {
            return DateTime.Now;
        }
    }
}

class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
{
    DataGridView dataGridView;
    private bool valueChanged = false;
    int rowIndex;

    public CalendarEditingControl()
    {
        this.Format = DateTimePickerFormat.Short;
    }

    public object EditingControlFormattedValue
    {
        get
        {
            return this.Value.ToShortDateString();
        }
        set
        {
            if (value is string)
            {
                this.Value = DateTime.Parse((string)value);
            }
        }
    }

    public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
    {
        return EditingControlFormattedValue;
    }

    public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
    {
        this.Font = dataGridViewCellStyle.Font;
        this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
        this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
    }

    public int EditingControlRowIndex
    {
        get
        {
            return rowIndex;
        }
        set
        {
            rowIndex = value;
        }
    }

    public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
    {
        switch (key & Keys.KeyCode)
        {
            case Keys.Left:
            case Keys.Up:
            case Keys.Down:
            case Keys.Right:
            case Keys.Home:
            case Keys.End:
            case Keys.PageDown:
            case Keys.PageUp:
                return true;
            default:
                return !dataGridViewWantsInputKey;
        }
    }

    public void PrepareEditingControlForEdit(bool selectAll)
    {
        
    }

    public bool RepositionEditingControlOnValueChange
    {
        get
        {
            return false;
        }
    }

    public DataGridView EditingControlDataGridView
    {
        get
        {
            return dataGridView;
        }
        set
        {
            dataGridView = value;
        }
    }

    public bool EditingControlValueChanged
    {
        get
        {
            return valueChanged;
        }
        set
        {
            valueChanged = value;
        }
    }

    public Cursor EditingPanelCursor
    {
        get
        {
            return base.Cursor;
        }
    }

    protected override void OnValueChanged(EventArgs eventargs)
    {
        valueChanged = true;
        this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
        base.OnValueChanged(eventargs);
    }
}
