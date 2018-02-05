# ListFrames
Xamarin Forms Rooms List with TimeSlots as Frames

I'm trying to resolve the following issue when running this sample app on a iOS device:

When you initial open the app you will see 3 rooms listed and each room displays 5 timeslots. You can switch to the 'OtherPage' and then switch back to the 'Frames' page, and you'll notice that you can still see 3 rooms listed and each room displays 5 timeslots.

Next 'Click' on the 'Add Timeslot' button. You'll now see 3 rooms listed and each room displays 6 instead of the previous 5 timeslots. Now switch to the 'OtherPage' and then back to the 'Frames' page.

On iOS you can now see that the Rooms and Timeslots do not display. 

On Droid, using this same test you'll still be able to see the 3 rooms listed and each room displays 6 timeslots.

Addition note
==============

Each time the 'Frames' page triggers the OnAppearing event, the list of rooms and timeslots are recreated by a call to the RoomsViewModel GetRooms() method.

Diagram of Classes
===================

RoomsViewModel
- Has a list of RoomViewModels

RoomViewModel 
- Has a list a TimeSlotViewModels

TimeSlotViewModel 
- Has a reference back to its RoomViewModel

TimeSlotButton (UI View)
- Has a BindingContext to a TimeSlotViewModel

App
- Has a property for the RoomsViewModel

Originally based on Xamarin Form Sample Data Template 
========================================================

[Xamarin Form Sample Data Templates](http://github.com/xamarin/xamarin-forms-samples/tree/master/Templates/DataTemplates).



