﻿namespace DotNetThumbor
{
    using System;
    using System.Collections.Generic;

    public interface IThumborImage
    {
        IThumborImage Resize(int? newWidth, int? newHeight);

        /// <summary>
        /// The smart.
        /// </summary>
        /// <param name="doSmartImage">
        /// The smart image.
        /// </param>
        /// <returns>
        /// The <see cref="Thumbor"/>.
        /// </returns>
        IThumborImage Smart(bool doSmartImage);

        IThumborImage Format(Thumbor.ImageFormat imageFormat);

        IThumborImage Crop(int topLeft, int topRight, int bottomLeft, int bottomRight);

        IThumborImage Quality(int? imageQuality);

        IThumborImage Grayscale(bool grayscaleImage);

        IThumborImage Watermark(string watermarkImageUrl, int right, int down, int transparency);

        IThumborImage Fill(string fillInColour);

        IThumborImage Trim(bool trimImage);

        IThumborImage FitIn(bool fitIn);

        IThumborImage FullFitIn(bool fullFitIn);

        IThumborImage HorizontalAlign(Thumbor.ImageHorizontalAlign align);

        IThumborImage VerticalAlign(Thumbor.ImageVerticalAlign align);

        IThumborImage HorizontalFlip(bool flipHorizontal);

        IThumborImage VerticalFlip(bool flipVertical);

        string ToUrl();

        string ToUnsafeUrl();

        IThumborImage Brightness(int brightness);

        IThumborImage Contrast(int contrast);

        IThumborImage Colorize(int redPercentage, int greenPercentage, int bluePercentage, string fillColor);

        IThumborImage Equalize(bool equalizeImage);

        IThumborImage MaxBytes(int? imageMaxBytes);

        IThumborImage Noise(int? imageNoise);

        IThumborImage NoUpscale(bool noUpscaleImage);

        IThumborImage Rgb(int red, int green, int blue);

        IThumborImage RoundCorners(int radiusA, int? radiusB, int red, int green, int blue);

        IThumborImage Rotate(int? imageRotateAngle);

        IThumborImage Saturation(double? imageSaturation);

        IThumborImage Sharpen(double sharpenAmount, double sharpenRadius, bool luminance);

        IThumborImage StripIcc(bool stripIccFromImage);

        IThumborImage Convolution(IList<int> matrix, int columns, bool shouldNormalise);

        IThumborImage Blur(int blurRadius, int? blurSigma);

        IThumborImage ExtractFocal();

        IThumborImage GifV(Thumbor.ImageGifVOption imageGifVOption);

        IThumborImage Curve(
            IList<Tuple<int, int>> curveAll,
            IList<Tuple<int, int>> curveRed,
            IList<Tuple<int, int>> curveGreen,
            IList<Tuple<int, int>> curveBlue);
    }
}
