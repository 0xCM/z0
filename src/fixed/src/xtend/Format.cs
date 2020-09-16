//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static string FormatHex(this Cell8 src, HexFormatOptions? config = null)
            => src.Content.FormatHex(config == null ? HexFormatOptions.HexData : config.Value);

        public static string FormatHex(this Cell16 src, HexFormatOptions? config = null)
            => src.Content.FormatHex(config == null ? HexFormatOptions.HexData : config.Value);

        public static string FormatHex(this Cell32 src, HexFormatOptions? config = null)
            => src.Content.FormatHex(config == null ? HexFormatOptions.HexData : config.Value);

        public static string FormatHex(this Cell64 src, HexFormatOptions? config = null)
            => src.Content.FormatHex(config == null ? HexFormatOptions.HexData : config.Value);
    }
}