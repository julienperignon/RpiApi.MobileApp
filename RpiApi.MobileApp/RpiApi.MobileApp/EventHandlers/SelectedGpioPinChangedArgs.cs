﻿using RpiApi.MobileApp.Enums;

namespace RpiApi.MobileApp.EventHandlers
{
    public class SelectedGpioPinChangedArgs
    {
        public SelectedGpioPinChangedArgs(GpioPin oldValue, GpioPin newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public GpioPin OldValue { get; set; }

        public GpioPin NewValue { get; set; }

        public bool ValueHasntChanged
        {
            get
            {
                return OldValue == NewValue;
            }
        }

    }
}