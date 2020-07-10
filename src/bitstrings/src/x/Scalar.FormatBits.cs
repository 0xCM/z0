//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Api = FormatBits;    

    partial class XTend
    {
        public static string FormatBits(this byte src, BitFormatConfig? config = null)            
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this sbyte src, BitFormatConfig? config = null)            
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this short src, BitFormatConfig? config = null)            
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this ushort src, BitFormatConfig? config = null)            
            => Api.format(src, config ?? BitFormatter.configure());
        public static string FormatBits(this uint src, BitFormatConfig? config = null)            
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this int src, BitFormatConfig? config = null)            
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this ulong src, BitFormatConfig? config = null)
            => Api.format(src, config ?? BitFormatter.configure());

        public static string FormatBits(this long src, BitFormatConfig? config = null)
            => Api.format(src, config ?? BitFormatter.configure());        
    }
}