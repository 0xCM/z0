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
        public static string format<W,T>(T value, W w = default, bool postspec = false)
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W8))
                return format(w8, Numeric.force<T,byte>(value), postspec);
            else if(typeof(W) == typeof(W16))
                return format(w16, Numeric.force<T,ushort>(value), postspec);
            else if(typeof(W) == typeof(W32))
                return format(w32, Numeric.force<T,uint>(value), postspec);
            else
                return format(w64, Numeric.force<T,ulong>(value), postspec);
        }

        [Op, Closures(Closure)]
        public static string format<T>(W8 w, T src, bool postspec = false)
            where T : unmanaged
                => format(w, uint8(src), postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W16 w, T src, bool postspec = false)
            where T : unmanaged
                => format(w, uint16(src), postspec);

        [Op, Closures(Closure)]
        public static string format<T>(W32 w, T src, bool postspec = false)
            where T : unmanaged
                => format(w, uint32(src), postspec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static string format<T>(W64 w, T src, bool postspec = false)
             where T : unmanaged
                => format(w, uint64(src), postspec);

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
    }
}