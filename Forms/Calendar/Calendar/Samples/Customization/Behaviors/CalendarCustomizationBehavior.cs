#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.ObjectModel;
using SampleBrowser.Core;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace SampleBrowser.SfCalendar
{
    internal class CalendarCustomizationBehavior : Behavior<SampleView>
    {
        private Syncfusion.SfCalendar.XForms.SfCalendar calendar;

        protected override void OnAttachedTo(SampleView bindable)
        {
            base.OnAttachedTo(bindable);
            this.calendar = bindable.Content.FindByName<Syncfusion.SfCalendar.XForms.SfCalendar>("calendar");
            ObservableCollection<string> customLabels = new ObservableCollection<string> { "S", "M", "T", "W", "T", "F", "S" };
            this.calendar.CustomDayLabels = customLabels;
            this.calendar.MonthViewSettings.HeaderFont = Font.OfSize("SemiBold", this.calendar.MonthViewSettings.HeaderFont.FontSize);
            this.calendar.MonthViewSettings.HeaderBackgroundColor = Color.White;
            this.calendar.MonthViewSettings.DateSelectionColor = Color.White;
            this.calendar.MonthViewSettings.TodayTextColor = Color.White;
            this.calendar.MonthViewSettings.SelectedDayTextColor = Color.Black;
            this.calendar.MonthViewSettings.CellGridOptions = CellGridOptions.None;
            this.calendar.MonthViewSettings.DayLabelTextAlignment = DayLabelTextAlignment.Center;
            if (Device.RuntimePlatform == "Android" || (Device.RuntimePlatform == "UWP" && Device.Idiom == TargetIdiom.Desktop))
            {
                this.calendar.HeaderHeight = 50;
            }
            else if (Device.RuntimePlatform == "iOS")
            {
                this.calendar.HeaderHeight = 40;
            }

            this.calendar.OnMonthCellLoaded += Calendar_OnMonthCellLoaded;
        }

        private void Calendar_OnMonthCellLoaded(object sender, MonthCellLoadedEventArgs e)
        {
            CalendarCustomizationViewModel viewModel = new CalendarCustomizationViewModel(e.IsCurrentMonth, e.Date);
            e.CellBindingContext = viewModel;
        }

        protected override void OnDetachingFrom(SampleView bindable)
        {
            base.OnDetachingFrom(bindable);
            calendar = null;
        }
    }
}

