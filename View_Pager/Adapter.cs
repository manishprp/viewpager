using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.ViewPager.Widget;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View_Pager
{
    class Adapter : PagerAdapter
    {
        Context context;
        ocean turT;
        ViewPager myView;
        private View view;

        public Adapter(Context context, ocean turT)
        {
            this.context = context;
            this.turT = turT;
        }

        public override int Count { get { return turT.NumbPhotos; } }

        public override bool IsViewFromObject(View view, Java.Lang.Object @object)
        {
            return view == @object;
        }

        [Obsolete]
        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            var image = new ImageView(context);
            image.SetImageResource(turT[position].PhotoId);
            myView = container.JavaCast<ViewPager>();
            myView.AddView(image);
            return image;
        }

        [Obsolete]
        public override void DestroyItem(View container, int position, Java.Lang.Object @object)
        {
            myView = container.JavaCast<ViewPager>();
            myView.RemoveView(view as View);
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(turT[position].Caption);
        }

    }
}