//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class FormatBits
    {
        public static string format<T>(ReadOnlySpan<T> src, BitFormatConfig config)
            where T : unmanaged
                => BitString.scalars(src)
                        .Truncate(config.MaxBitCount)
                        .Format(config.TrimLeadingZeros, config.SpecifierPrefix, config.BlockWidth, config.BlockSep, config.RowWidth); 

        public static string format<T>(Span<T> src, BitFormatConfig config)            
                where T : unmanaged
                    => format(src.ReadOnly(), config);

        public static string format(ReadOnlySpan<bit> src, BitFormatConfig? fmt = null)
            => src.ToBitString().Format(fmt);
            
        public static string format(Span<bit> src,  BitFormatConfig? fmt = null)
            => format(src.ReadOnly(), fmt);

        public static string format<N,T>(NatSpan<N,T> src, BitFormatConfig config)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => format(src.Data.ReadOnly(), config);
    }
}