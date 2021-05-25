//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    using static Root;
    using static core;
    using static HexFormatSpecs;

    [ApiHost]
    public readonly struct HexMemoryFormat
    {
        [Op]
        public static string asmhex(sbyte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2")) + PostSpec;

        [Op]
        public static string asmhex(byte src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2")) + PostSpec;

        [Op]
        public static string asmhex(short src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4")) + PostSpec;

        [Op]
        public static string asmhex(ushort src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4")) + PostSpec;

        [Op]
        public static string asmhex(int src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string asmhex(uint src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8")) + PostSpec;

        [Op]
        public static string asmhex(ulong src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string asmhex(long src, int? digits = null)
            => digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x")) + PostSpec;

        [Op]
        public static string asmhex(ushort src, NumericWidth width)
        {
            return width switch{
                    NumericWidth.W8 => asmhex((byte)src,2),
                    _ => asmhex(src,4),
            };
        }

        [Op]
        public static string asmhex(uint src, NumericWidth width)
        {
            return width switch{
                    NumericWidth.W8 => asmhex((byte)src,2),
                    NumericWidth.W16 => asmhex((ushort)src,4),
                    _ => asmhex(src,8),
            };
        }

        [Op]
        public static string asmhex(ulong src, NumericWidth width)
        {
            return width switch{
                    NumericWidth.W8 => asmhex((byte)src,2),
                    NumericWidth.W16 => asmhex((ushort)src,4),
                    NumericWidth.W32 => asmhex((uint)src,8),
                    _ => asmhex(src,12),
            };
        }

        [Op]
        public static string bytes(ushort src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(short src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(int src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(uint src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(long src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [Op]
        public static string bytes(ulong src)
            => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);
    }
}