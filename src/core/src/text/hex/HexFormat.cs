//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static HexFormatSpecs;

    [ApiHost]
    public readonly struct HexFormat
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static bool HasPreSpec(string src)
            => src.TrimStart().StartsWith(PreSpec);

        [MethodImpl(Inline)]
        public static bool HasPostSpec(string src)
            => src.TrimEnd().EndsWith(PostSpec);

        [Op]
        public static string format(W8 w, byte src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex8Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [Op]
        public static string format(W16 w, ushort src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex16Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [Op]
        public static string format(W32 w, uint src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex32Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

        [Op]
        public static string format(W64 w, ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.Hex64Spec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);

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
        public static string format(byte src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(sbyte src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x2"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(short src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(ushort src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x4"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(int src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(uint src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x8"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(long src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x"))
            + (postspec ? PostSpec : EmptyString);

        [Op]
        public static string format(ulong src, int? digits = null, bool prespec = false, bool postspec = false)
            => (prespec ? HexFormatSpecs.PreSpec : EmptyString)
            + digits.Map(n => src.ToString($"x{n}"), () => src.ToString("x"))
            + (postspec ? PostSpec : EmptyString);

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

        public static string bytes<T>(T src)
            where T : unmanaged
                => core.bytes(src).HexCoreFormat(HexFormatSpecs.HexData);

        [MethodImpl(Inline), Op]
        public static string format<W,T>(T value, W w = default, bool postspec = false)
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W8))
                return format(w8, bw8(value), postspec);
            else if(typeof(W) == typeof(W16))
                return format(w16, bw16(value), postspec);
            else if(typeof(W) == typeof(W32))
                return format(w32, bw32(value), postspec);
            else
                return format(w64, bw64(value), postspec);
        }
    }
}