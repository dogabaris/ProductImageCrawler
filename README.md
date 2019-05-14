# ProductImageCrawler
Product Image Crawler with given SKU, better use it behind VPN

### Simply call in Program.cs
```
ImageHelper imgHelper = new ImageHelper();
```
and call SearchForImages function
```
var searchKey = "P336769308";
var returnedImgLinks = imgHelper.SearchForImages(searchKey + " site:urun.n11.com")
```
it returns image links.

Better use it behind vpn.
Don't forget to change vpn location when `G o o g l e` catch you :p
