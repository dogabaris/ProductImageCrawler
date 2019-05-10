using SchedulerBoilerplate.Helpers;
using System;

namespace GetImageLinkz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started to crawl specified SKU image links on 'Google Images'!");
            var givenSku = "P336769308";
            ImageHelper imgHelper = new ImageHelper();
            var images_urls = imgHelper.SearchForImages(givenSku + " site:urun.n11.com");

            Console.ReadKey();
        }
    }
}
