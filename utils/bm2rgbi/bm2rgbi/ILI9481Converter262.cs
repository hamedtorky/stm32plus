﻿using System.Drawing;
using System.IO;

namespace bm2rgbi {
  
  /// <summary>
  /// 262K colour converter
  /// </summary>
  
  class ILI9481Converter262 : ILI9481Converter, IBitmapConverter {

    private Generic666RGBConverter _converter=new Generic666RGBConverter();

    /// <summary>
    /// Do the conversion
    /// </summary>

    public void convert(Bitmap bm,FileStream fs) {
      _converter.convert(bm,fs);
    }
  }
}
