using FlickrNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WallpaperChanger.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestService()
        {
            FlickrHelper helper = new FlickrHelper();
            PhotoCollection testCol = helper.GetData();

            Assert.IsNotNull(testCol);
        }
    }
}
