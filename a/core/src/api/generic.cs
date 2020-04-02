//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static T generic<T>(char src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(bool src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(sbyte src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(byte src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(short src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(ushort src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(int src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(uint src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(long src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(ulong src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(float src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static T generic<T>(double src)
            => As.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref sbyte src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref byte src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref short src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref ushort src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref int src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref uint src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref ulong src)
            => ref As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static sbyte int8<T>(T src)
            => As.int8(src);

        [MethodImpl(Inline)]
        public static byte uint8<T>(T src)
            => As.uint8(src);

        [MethodImpl(Inline)]
        public static short int16<T>(T src)
            => As.int16(src);

        [MethodImpl(Inline)]
        public static ushort uint16<T>(T src)
            => As.uint16(src);

        [MethodImpl(Inline)]
        public static int int32<T>(T src)
            => As.int32(src);

        [MethodImpl(Inline)]
        public static uint uint32<T>(T src)
            => As.uint32(src);

        [MethodImpl(Inline)]
        public static long int64<T>(T src)
            => As.int64(src);

        [MethodImpl(Inline)]
        public static ulong uint64<T>(T src)
            => As.uint64(src);

        [MethodImpl(Inline)]
        public static float float32<T>(T src)
            => As.float32(src);

        [MethodImpl(Inline)]
        public static double float64<T>(T src)
            => As.float64(src);

        [MethodImpl(Inline)]
        public static ref sbyte int8<T>(ref T src)
            => ref As.int8(ref src);

        [MethodImpl(Inline)]
        public static ref byte uint8<T>(ref T src)
            => ref As.uint8(ref src);

        [MethodImpl(Inline)]
        public static ref short int16<T>(ref T src)
            => ref As.int16(ref src);

        [MethodImpl(Inline)]
        public static ref ushort uint16<T>(ref T src)
            => ref As.uint16(ref src);

        [MethodImpl(Inline)]
        public static ref int int32<T>(ref T src)
            => ref As.int32(ref src);

        [MethodImpl(Inline)]
        public static ref uint uint32<T>(ref T src)
            => ref As.uint32(ref src);

        [MethodImpl(Inline)]
        public static ref long int64<T>(ref T src)
            => ref As.int64(ref src);

        [MethodImpl(Inline)]
        public static ref ulong uint64<T>(ref T src)
            => ref As.uint64(ref src);

        [MethodImpl(Inline)]
        public static ref float float32<T>(ref T src)
            => ref As.float32(ref src);

        [MethodImpl(Inline)]
        public static ref double float64<T>(ref T src)
            => ref As.float64(ref src);

        [MethodImpl(Inline)]
        public static sbyte? int8<T>(T? src)
            where T : unmanaged
                => As.int8(src);

        [MethodImpl(Inline)]
        public static byte? uint8<T>(T? src)
            where T : unmanaged
                => As.uint8(src);

        [MethodImpl(Inline)]
        public static short? int16<T>(T? src)
            where T : unmanaged
                => As.int16(src);

        [MethodImpl(Inline)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => As.uint16(src);

        [MethodImpl(Inline)]
        public static int? int32<T>(T? src)
            where T : unmanaged
                => As.int32(src);

        [MethodImpl(Inline)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => As.uint32(src);

        [MethodImpl(Inline)]
        public static long? int64<T>(T? src)
            where T : unmanaged
                => As.int64(src);

        [MethodImpl(Inline)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => As.uint64(src);

        [MethodImpl(Inline)]
        public static float? float32<T>(T? src)
            where T : unmanaged
                => As.float32(src);

        [MethodImpl(Inline)]
        public static double? float64<T>(T? src)
            where T : unmanaged
                => As.float64(src);
    }
}