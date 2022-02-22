using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Collections.Generic;

/// <summary>
/// Provides methods to perfrom various image processing techniques.
/// </summary>
class ImageProcessor {

    /// <summary>
    /// Converts a list of image(s) to thumbnails of given height. 
    /// </summary>
    /// <param name="filenames">List of images to convert.</param>
    /// <param name="height">Target height of thumbnail.</param>
    public static void Thumbnail(string[] filenames, int height)
    {
        // Iterate through all .jpg files in images directory
        Parallel.ForEach(filenames, (imagePath) =>
        {
            {
                // For each image file create a new Bitmap object
                Bitmap image = new Bitmap(imagePath);

                // Calculate new thumbnail width
                int thumbnailWidth = image.Width / (image.Height / height);

                Image thumbnail = image.GetThumbnailImage(thumbnailWidth, height, () => { return false; }, IntPtr.Zero);

                // Extract filename from path and edit for new save
                string[] nameSplit = imagePath.Split(new Char[] {'/', '.'});
                String newFilename = nameSplit[nameSplit.Length - 2] + "_th." +
                                        nameSplit[nameSplit.Length - 1];

                // Save inverted image to new file
                thumbnail.Save(newFilename);
            }
        });
    }
