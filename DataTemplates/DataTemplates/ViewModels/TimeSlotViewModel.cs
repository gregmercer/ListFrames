using System;
using Xamarin.Forms;

using DataTemplates.Views;

namespace DataTemplates.ViewModels
{
    public class TimeSlotViewModel : SimpleViewModel
    {
        public TimeSlotViewModel()
        {
        }

        public RoomViewModel RoomViewModel { get; set; }

        public Frame TimeSlotFrame { get; set; }

        string startTime = "";
        public string StartTime {
            get { return this.startTime; }
            set
            {
                if (this.startTime == value) {
                    return;
                }

                this.startTime = value;
            }
        }
    }
}
