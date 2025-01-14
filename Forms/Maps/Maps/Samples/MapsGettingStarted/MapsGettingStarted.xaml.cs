#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Core;
using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace SampleBrowser.SfMaps
{
    [Preserve(AllMembers = true)]
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapsGettingStarted : SampleView
    {
        public MapsGettingStarted()
        {
            InitializeComponent();

          (this.Maps.Layers[0] as ShapeFileLayer).ShapeSettings.ColorMappings.Clear();    
          (this.Maps.Layers[0] as ShapeFileLayer).MarkerSettings.TooltipSettings.TooltipTemplate = grid.Resources["toolTipTemplate"] as DataTemplate; 		  
                
        }
       
    }

    public class CustomMarker : MapMarker
    {
        public ImageSource ImageName { get; set; }
        public  String Population { get; set; }
        public CustomMarker()
        {
            if (Device.RuntimePlatform == Device.UWP)
            {
#if COMMONSB
                ImageName = ImageSource.FromResource("SampleBrowser.Icons.pin.png", typeof(CustomMarker).GetTypeInfo().Assembly);
#else
                ImageName = ImageSource.FromResource("SampleBrowser.SfMaps.Icons.pin.png", typeof(CustomMarker).GetTypeInfo().Assembly);
#endif
            }
            else
            {
#if COMMONSB
                ImageName = ImageSource.FromResource("SampleBrowser.Icons.pin.png");
#else
                ImageName = ImageSource.FromResource("SampleBrowser.SfMaps.Icons.pin.png");
#endif
            }
        }
    }
}
