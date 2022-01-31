using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace View_Pager
{

    public class Photo
    {
        public Photo(int id, string caption)
        {
            PhotoId = id;
            Caption = caption;
        }

        public int PhotoId { get; }
        public string Caption { get; }
    }

    class ocean
    {
        static Photo[] toursim = {

           new Photo(Resource.Drawable.Android1,"GoldFish"),
           new Photo(Resource.Drawable.Android2,"Pirana"),
           new Photo(Resource.Drawable.Android3,"Koi"),
           new Photo(Resource.Drawable.Android4,"Moli"),
           new Photo(Resource.Drawable.Android5,"oscar"),
           new Photo(Resource.Drawable.Android6,"H2")



        };

        public Photo[] myPhoto;

        public ocean()
        {
            myPhoto = toursim;
        }

        public int NumbPhotos
        {
            get { return myPhoto.Length; }
        }

        public Photo this[int i]
        {
            get { return myPhoto[i]; }
        }
    }

}