using System;
using MaderaDevisBuilder.Droid;
using MaderaDevisBuilder.Components;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Content.Res;
using Android.Graphics;

[assembly: ExportRenderer(typeof(MDEntry), typeof(MDEntryRenderer))]


namespace MaderaDevisBuilder.Droid
{
    public class MDEntryRenderer : EntryRenderer
    {
        public MDEntryRenderer() : base(global::Android.App.Application.Context){}

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcIn);
            }
        }
    }
}
