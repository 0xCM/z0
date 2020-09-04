//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class FormatBits
    {
        public static string format(sbyte src, BitFormat config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(byte src, BitFormat config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(short src, BitFormat config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(ushort src, BitFormat config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(int src, BitFormat config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(uint src, BitFormat config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(long src, BitFormat config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(ulong src, BitFormat config)
            => format(src. ToBitString(config.MaxBitCount), config);

        public static string format(byte src, NumericBaseKind @base)
            => @base switch{
                NumericBaseKind.Base2 => src.FormatBits(),
                NumericBaseKind.Base16 => src.FormatHex(),
                _=> src.ToString(),
            };

        public static string format(ushort src, NumericBaseKind @base)
            => @base switch{
                NumericBaseKind.Base2 => src.FormatBits(),
                NumericBaseKind.Base16 => src.FormatHex(),
                _=> src.ToString(),
            };

        public static string format(uint src, NumericBaseKind @base)
            => @base switch{
                NumericBaseKind.Base2 => src.FormatBits(),
                NumericBaseKind.Base16 => src.FormatHex(),
                _=> src.ToString(),
            };

        public static string format(ulong src, NumericBaseKind @base)
            => @base switch{
                NumericBaseKind.Base2 => src.FormatBits(),
                NumericBaseKind.Base16 => src.FormatHex(),
                _=> src.ToString(),
            };
    }
}