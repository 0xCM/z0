//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    partial class FormatBits
    {
        public static string format(sbyte src, BitFormatConfig config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(byte src, BitFormatConfig config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(short src, BitFormatConfig config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(ushort src, BitFormatConfig config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(int src, BitFormatConfig config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(uint src, BitFormatConfig config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(long src, BitFormatConfig config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(ulong src, BitFormatConfig config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(byte src, NumericBase @base)
            => @base switch{
                NumericBase.Binary => src.FormatBits(),
                NumericBase.Hex => src.FormatHex(),
                _=> src.ToString(),
            };                    

        public static string format(ushort src, NumericBase @base)
            => @base switch{
                NumericBase.Binary => src.FormatBits(),
                NumericBase.Hex => src.FormatHex(),
                _=> src.ToString(),
            };                    

        public static string format(uint src, NumericBase @base)
            => @base switch{
                NumericBase.Binary => src.FormatBits(),
                NumericBase.Hex => src.FormatHex(),
                _=> src.ToString(),
            };                    

        public static string format(ulong src, NumericBase @base)
            => @base switch{
                NumericBase.Binary => src.FormatBits(),
                NumericBase.Hex => src.FormatHex(),
                _=> src.ToString(),
            };      
    }
}