//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Memories
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static byte uint8<T>(T src)
            => z.uint8(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ushort uint16<T>(T src)
            => z.uint16(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint uint32<T>(T src)
            => z.uint32(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ulong uint64<T>(T src)
            => z.uint64(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static sbyte int8<T>(T src)
            => z.int8(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static short int16<T>(T src)
            => z.int16(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static int int32<T>(T src)
            => z.int32(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static long int64<T>(T src)
            => z.int64(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static float float32<T>(T src)
            => AsDeprecated.float32(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static double float64<T>(T src)
            => z.float64(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static decimal float128<T>(T src)
            => z.float128(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static char char16<T>(T src)
            => z.char16(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bool bool8<T>(T src)
            => z.@bool(src);
    }
}