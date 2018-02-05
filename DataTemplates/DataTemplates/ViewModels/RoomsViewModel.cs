using System;
using System.Collections.Generic;
using System.Windows.Input;

using Xamarin.Forms;

using DataTemplates.Model;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DataTemplates.ViewModels
{
    public enum BookRoomResults
    {
        Failed,
        Success,
    }

    public class RoomsViewModel : SimpleViewModel
    {
        public ICommand GetRoomsCommand { get; private set; }

        public RoomsViewModel()
        {
            GetRoomsCommand = new Command(async () => await GetRooms());
        }

        // Commands

        protected async Task GetRooms()
        {
            ObservableCollection<RoomViewModel> roomsList = new ObservableCollection<RoomViewModel>{};

            if (Rooms != null)
            {
                Rooms.Clear();
            }

            for (int index = 0; index < 3; index++)
            {
                List<TimeSlotViewModel> tsvmList = new List<TimeSlotViewModel>();
                RoomViewModel rvm = new RoomViewModel() { Index = index, Name = "Room " + index, TimeSlots = tsvmList };

                var timeSlots = new List<string>();
                for (var slotIndex = 0; slotIndex < NumberSlots; slotIndex++)
                {
                    var slotNumber = 30 * slotIndex;
                    var slotText = slotNumber.ToString();

                    TimeSlotViewModel tsm = new TimeSlotViewModel() { StartTime = slotText, RoomViewModel = rvm };
                    tsvmList.Add(tsm);
                }

                roomsList.Add(rvm);
            }

            Rooms = roomsList;
        }

        // Properties

        public int NumberSlots { set; get; }

        private ObservableCollection<RoomViewModel> rooms;
        public ObservableCollection<RoomViewModel> Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                rooms = value;
                RaisePropertyChanged();
            }
        }
    }
}
