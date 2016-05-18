using System;
using FlickrNet;

namespace WallpaperChanger.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FlickrHelper helper = new FlickrHelper();
            PhotoCollection col = helper.GetData();

            foreach (Photo photo in col)
            {
                if (string.IsNullOrEmpty(photo.Large2048Url))
                {
                    continue;
                }
                System.Console.WriteLine($"Photo {photo.Title} has URL {photo.Large2048Url}");
            }

            Wallpaper.Set(new Uri(col[0].Large2048Url), Wallpaper.Style.Stretched);
        }
    }
}
