#region Copyright Syncfusion Inc. 2001-2017.
// ------------------------------------------------------------------------------------
// <copyright file = "PagerAppearance.cs" company="Syncfusion.com">
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.
// </copyright>
// ------------------------------------------------------------------------------------
#endregion

namespace SampleBrowser.SfDataGrid
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SampleBrowser.Core;
    using Syncfusion.SfDataGrid.XForms;
    using Syncfusion.SfDataGrid.XForms.DataPager;
    using Xamarin.Forms;

    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]

    /// <summary>
    /// Custom class of Data Pager Appearance Manager to override the Colors
    /// </summary>
    public class PagerAppearance : AppearanceManager
    {
        /// <summary>
        /// Override this method to apply the custom style for pager button
        /// </summary>
        /// <returns>Color as given</returns>
        public override Color GetPagerButtonBorderColor()
        {
            return Color.Black;
        }
    }
}
