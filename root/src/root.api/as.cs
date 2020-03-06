//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Root
    {

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref sbyte int8<T>(in T src)
            => ref Unsafe.As<T,sbyte>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref byte uint8<T>(in T src)
            => ref Unsafe.As<T,byte>(ref edit(in src));            

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref short int16<T>(in T src)
            => ref Unsafe.As<T,short>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ushort uint16<T>(in T src)
            => ref Unsafe.As<T,ushort>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref int int32<T>(in T src)
            => ref Unsafe.As<T,int>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref uint uint32<T>(in T src)
            => ref Unsafe.As<T,uint>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref long int64<T>(in T src)
            => ref Unsafe.As<T,long>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref ulong uint64<T>(in T src)
            => ref Unsafe.As<T,ulong>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref float float32<T>(in T src)
            => ref Unsafe.As<T,float>(ref edit(in src));
        
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref double float64<T>(in T src)
            => ref Unsafe.As<T,double>(ref edit(in src));

        [MethodImpl(Inline)]
        public static ref char char16<T>(in T src)
            => ref Unsafe.As<T,char>(ref edit(in src));        

        [MethodImpl(Inline)]
        public static ref T generic<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in char src)
            => ref Unsafe.As<char,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in sbyte src)
            => ref Unsafe.As<sbyte,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in byte src)
            => ref Unsafe.As<byte,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in short src)
            => ref Unsafe.As<short,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in ushort src)
            => ref Unsafe.As<ushort,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in int src)
            => ref Unsafe.As<int,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in uint src)
            => ref Unsafe.As<uint,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in long src)
            => ref Unsafe.As<long,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in ulong src)
            => ref Unsafe.As<ulong,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in float src)
            => ref Unsafe.As<float,T>(ref edit(in src));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static ref T generic<T>(in double src)
            => ref Unsafe.As<double,T>(ref edit(in src));            
    }
}