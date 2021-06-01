//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Regs
    {
        [Op, Closures(UnsignedInts)]
        public static string format<T>(IReg<T> src)
            where T : unmanaged
        {
            switch(src.Width)
            {
                case RegWidth.W8:
                    return format(src as IReg8<T>);
                case RegWidth.W16:
                    return format(src as IReg16<T>);
                case RegWidth.W32:
                    return format(src as IReg32<T>);
                case RegWidth.W64:
                    return format(src as IReg64<T>);
                default:
                    var data = bytes(src.Content);
                    var formatter = HexFormatter.formatter<byte>();
                    return formatter.Format(data);
            }
        }

        [Op, Closures(UInt8k)]
        public static string format<T>(IReg8<T> src)
            where T : unmanaged
                => bw8(src.Content).FormatHex(specifier:false);

        [Op, Closures(UInt16k)]
        public static string format<T>(IReg16<T> src)
            where T : unmanaged
                => bw16(src.Content).FormatHex(specifier:false);

        [Op, Closures(UInt32k)]
        public static string format<T>(IReg32<T> src)
            where T : unmanaged
                => bw32(src.Content).FormatHex(specifier:false);

        [Op, Closures(UInt64k)]
        public static string format<T>(IReg64<T> src)
            where T : unmanaged
                => bw64(src.Content).FormatHex(specifier:false);
    }
}