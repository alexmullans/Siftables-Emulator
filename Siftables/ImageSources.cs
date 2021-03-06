﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Media.Imaging;
using Sifteo;

namespace Siftables
{
    public class ImageSources : MediaSources
    {

        public Dictionary<string, BitmapImage> ImageSource { get; private set; }
        private static readonly string[] ValidImageExtensions = new[] {".png", ".PNG", ".gif", ".GIF"};

        public ImageSources(string imagePath)
        {
            ImageSource = new Dictionary<string, BitmapImage>();
            LoadMedia(imagePath);
        }

        public override bool IsValidExtension(string extension)
        {
            return ValidImageExtensions.Contains(extension);
        }

        private void LoadMedia(string mediaPath)
        {
            foreach (var file in LoadMediaFiles(mediaPath))
            {
                var bitmapImage = new BitmapImage();
                bitmapImage.SetSource(new MemoryStream(File.ReadAllBytes(file.FullName)));
                ImageSource.Add(file.Name, bitmapImage);
            }
        }

        public ImageInfo GetImageInfo(string imageName)
        {
            return new ImageInfo
                       {
                           name = imageName,
                           height = ImageSource[imageName].PixelHeight,
                           width = ImageSource[imageName].PixelWidth
                       };
        }

        public BitmapImage GetBitmapImage(string imageName)
        {
            return ImageSource[imageName];
        }

        public override object GetMediaSet()
        {
            var imageNames = ImageSource.Keys;
            var imageInfosCollection = new Collection<ImageInfo>();
            foreach (var imageName in imageNames)
            {
                imageInfosCollection.Add(GetImageInfo(imageName));
            }
            var imageSet = new ImageSet(imageInfosCollection);
            return imageSet;
        }

        public override object this[string mediaName]
        {
            get { return ImageSource[mediaName]; }
        }

        public override bool Contains(string imageName)
        {
            if (imageName == null)
            {
                return false;
            }
            return ImageSource.ContainsKey(imageName);
        }
    }
}
