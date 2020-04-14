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
        public static string FormatBits<T>(this ReadOnlySpan<T> src, BitFormatConfig? config = null)
            where T : unmanaged
                => Api.format(src, config ?? BitFormatConfig.Default);
        
        public static string FormatBits<T>(this Span<T> src, BitFormatConfig? config = null)
            where T : unmanaged
                => Api.format(src.ReadOnly(), config ?? BitFormatConfig.Default);
    }
}