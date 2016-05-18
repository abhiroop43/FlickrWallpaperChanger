using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;

namespace WallpaperChanger
{
    public class FlickrHelper
    {
        public PhotoCollection GetData()
        {
            Flickr flickr = new Flickr("43299afdd8dd4f0d915c524507aff544", "d3793728e72cb582");
            //var options = new PhotoSearchOptions { Tags = "sunset", PerPage = 20, Page = 1 };
            var options = new PhotoSearchOptions { Tags = "sunset", Extras = PhotoSearchExtras.Large2048Url};
            PhotoCollection photos = flickr.PhotosSearch(options);

            return photos;
        }
    }
}
