//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    partial class As
    {
        [MethodImpl(Inline)]
        public static bit bitval<T>(T src)
            => Unsafe.As<T,bit>(ref src);        

        [MethodImpl(Inline)]
        public static char char16<T>(T src)        
            => Unsafe.As<T,char>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(char src)
            => Unsafe.As<char,T>(ref src);                 

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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(sbyte src)
            => Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref sbyte src)
            => ref Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(byte src)
            => Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref byte src)
            => ref Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(short src)
            => Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref short src)
            => ref Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(ushort src)
            => Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref ushort src)
            => ref Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(int src)
            => Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref int src)
            => ref Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(uint src)
            => Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref uint src)
            => ref Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(long src)
            => Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(ulong src)
            => Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref long src)
            => ref Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(ref ulong src)
            => ref Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(float src)
            => Unsafe.As<float,T>(ref src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T generic<T>(double src)
            => Unsafe.As<double,T>(ref src);
    }
}