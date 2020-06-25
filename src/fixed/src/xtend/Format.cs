//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static string FormatHex(this Fixed8 src, HexFormatConfig? config = null)
            => src.Content.FormatHex(config == null ? HexFormatConfig.HexData : config.Value);

        public static string FormatHex(this Fixed16 src, HexFormatConfig? config = null)
            => src.Content.FormatHex(config == null ? HexFormatConfig.HexData : config.Value);

        public static string FormatHex(this Fixed32 src, HexFormatConfig? config = null)
            => src.Content.FormatHex(config == null ? HexFormatConfig.HexData : config.Value);

        public static string FormatHex(this Fixed64 src, HexFormatConfig? config = null)
            => src.Content.FormatHex(config == null ? HexFormatConfig.HexData : config.Value);
    }
}