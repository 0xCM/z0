//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class As
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static sbyte int8<T>(T src)
            => Unsafe.As<T,sbyte>(ref src);        

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static byte uint8<T>(T src)
            => Unsafe.As<T,byte>(ref src);        

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static short int16<T>(T src)
            => Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ushort uint16<T>(T src)
            => Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int int32<T>(T src)
            => Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static uint uint32<T>(T src)
            => Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref uint uint32<T>(ref T src)
            => ref Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static long int64<T>(T src)
            => Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ulong uint64<T>(T src)
            => Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static float float32<T>(T src)
            => Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static double float64<T>(T src)
            => Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref sbyte int8<T>(ref T src)
            => ref Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte uint8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref short int16<T>(ref T src)
            => ref Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ushort uint16<T>(ref T src)
            => ref Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref int int32<T>(ref T src)
            => ref Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref long int64<T>(ref T src)
            => ref Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ulong uint64<T>(ref T src)
            => ref Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref float float32<T>(ref T src)
            => ref Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref double float64<T>(ref T src)
            => ref Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static sbyte? int8<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, sbyte?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static short? int16<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, short?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ushort? uint16<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, ushort?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static int? int32<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, int?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static uint? uint32<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, uint?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static long? int64<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, long?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ulong? uint64<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, ulong?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static float? float32<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, float?>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static double? float64<T>(T? src)
            where T : unmanaged
                => Unsafe.As<T?, double?>(ref src);
    }
}