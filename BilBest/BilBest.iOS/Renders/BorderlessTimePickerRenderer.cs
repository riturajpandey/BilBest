using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BilBest.CustomControls;
using BilBest.iOS.Renders;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessTimePicker), typeof(BorderlessTimePickerRenderer))]
namespace BilBest.iOS.Renders
{
    public class BorderlessTimePickerRenderer : TimePickerRenderer
    {
        #region Overrides Methods
        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);
            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        } 
        #endregion
    }
}