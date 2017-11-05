/*

 MIT License

 Copyright (c) 2017 Ed Snider
 Based on Swift implementation by Max Stein (https://github.com/allgamesallfree/ScreenType)

 Permission is hereby granted, free of charge, to any person obtaining a copy 
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.

*/

using System;
using UIKit;

namespace ScreenType
{
    /// <summary>
    /// Screen types for all available iPhones and iPads
    /// 
    /// - iPhone3_5: 3.5 inch iPhone (4, 4s)
    /// - iPhone4_0: 4.0 inch iPhone (5, 5s, 5c)
    /// - iPhone4_7: 4.7 inch iPhone (6/6s, 7, 8)
    /// - iPhone5_5: 5.5 inch iPhone (6/6s plus, 7 plus, 8 plus)
    /// - iPhone5_8: 5.8 inch iPhone (X)
    /// - iPad9_7:   9.7 inch iPad
    /// - iPad10_5:  10.5 inch iPad
    /// - iPad12_9:  12.9 inch iPad
    /// </summary>
    public enum ScreenType
    {
        iPhone3_5 = 1,
        iPhone4_0 = 2,
        iPhone4_7 = 3,
        iPhone5_5 = 4,
        iPhone5_8 = 5,
        iPad9_7 = 6,
        iPad10_5 = 7,
        iPad12_9 = 8 
    }

    public static class ScreenTypeExtensions
    {
        /// <summary>
        /// Gets the iPhone / iPad screen type.
        /// </summary>
        /// <returns>ScreenType for the provided UIScreen object</returns>
        public static ScreenType GetScreenType(this UIScreen screen)
        {
            if (screen == null)
            {
                throw new ArgumentNullException(nameof(screen));
            }

            var screenLongestSide = Math.Max(screen.Bounds.Width, screen.Bounds.Height);

            switch (screenLongestSide)
            {
                case 480:
                    return ScreenType.iPhone3_5;
                case 568:
                    return ScreenType.iPhone4_0;
                case 667:
                    return ScreenType.iPhone4_7;
                case 736:
                    return ScreenType.iPhone5_5;
                case 812:
                    return ScreenType.iPhone5_8;
                case 1024:
                    return ScreenType.iPad9_7;
                case 1111:
                    return ScreenType.iPad10_5;
                default:
                    return ScreenType.iPad12_9;
            }
        }
    }
}
