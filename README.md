# ScreenType for Xamarin.iOS

[![NuGet](https://img.shields.io/nuget/v/ScreenType.svg?label=NuGet)](https://www.nuget.org/packages/ScreenType/)
[![Build status](https://ci.appveyor.com/api/projects/status/xwga45isl2u25j73?svg=true)](https://ci.appveyor.com/project/edsnider/screentype)

Easily distinguish between iOS device screen types in Xamarin.iOS apps.

This library is a C# port of [Matt Stein's](https://github.com/allgamesallfree) [ScreenType](https://github.com/allgamesallfree/ScreenType) library for Objective-C and Swift.

## API Usage
The main way to use this library is via its `UIScreen` extension method `GetScreenType()`. The method returns a [`ScreenType`](https://github.com/edsnider/screentype/blob/3c8df96415eba3f6718b4243d02c654d03f7896b/src/ScreenType/ScreenType.cs#L36) enum that represents the size of the current iPhone or iPad screen:

```csharp
using UIKit;
using ScreenType;

var screenType = UIScreen.MainScreen.GetScreenType();

if (screenType == ScreenType.iPhone5_8)
{
    Console.WriteLine("This device is an iPhone X.");
}

if (screenType > ScreenType.iPhone4_0)
{
    Console.WriteLine("This device is larger than an iPhone 5/5s/5c.");
}
```

## License
Licensed under MIT. See [License file](https://github.com/edsnider/screentype/blob/master/LICENSE).