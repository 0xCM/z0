//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct HexFormat
    {
        [MethodImpl(Inline), Op]
        public static string format<W,T>(T value, W w = default)
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W8))
                return SmallHex.format(Numeric.force<T,byte>(value));
            else if(typeof(W) == typeof(W16))
                return SmallHex.format(Numeric.force<T,ushort>(value));
            else if(typeof(W) == typeof(W32))
                return SmallHex.format(Numeric.force<T,uint>(value));
            else
                return SmallHex.format(Numeric.force<T,ulong>(value));
        }

        [Op]
        public static string format(W8 w, byte src, bool postspec = false)
            => format8(src,postspec);

        [Op]
        public static string format(W16 w, ushort src, bool postspec = false)
            => format16(src,postspec);

        [Op]
        public static string format(W32 w, uint src, bool postspec = false)
            => format32(src,postspec);

        [Op]
        public static string format(W64 w, ulong src, bool postspec = false)
            => format64(src,postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W8 w, T src, bool postspec = false)
            where T : unmanaged
                => format8(uint8(src), postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W16 w, T src, bool postspec = false)
            where T : unmanaged
                => format16(uint16(src), postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W32 w, T src, bool postspec = false)
            where T : unmanaged
                => format32(uint32(src), postspec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(W64 w, T src, bool postspec = false)
             where T : unmanaged
                => format64(uint64(src), postspec);

        [Op]
        static string format8(byte src, bool postspec = false)
            => format64(((ulong)src), postspec);

        [Op]
        static string format16(ushort src, bool postspec = false)
            => format64(((ulong)src), postspec);

        [Op]
        static string format32(uint src, bool postspec = false)
            => format64(((ulong)src), postspec);

        [Op]
        static string format64(ulong src, bool postspec = false)
            => src.ToString(HexFormatSpecs.SmallHexSpec) + (postspec ? HexFormatSpecs.PostSpec : EmptyString);
    }
}