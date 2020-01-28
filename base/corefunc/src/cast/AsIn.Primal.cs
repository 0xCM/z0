//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    

    partial class AsIn
    {
        [MethodImpl(Inline)]
        static ref T asRef<T>(in T src)
            => ref Unsafe.AsRef(in src);

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref sbyte int8<T>(in T src)
            => ref Unsafe.As<T,sbyte>(ref asRef(in src));

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref byte uint8<T>(in T src)
            => ref Unsafe.As<T,byte>(ref asRef(in src));            

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref short int16<T>(in T src)
            => ref Unsafe.As<T,short>(ref asRef(in src));

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref ushort uint16<T>(in T src)
            => ref Unsafe.As<T,ushort>(ref asRef(in src));

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref int int32<T>(in T src)
            => ref Unsafe.As<T,int>(ref asRef(in src));

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref uint uint32<T>(in T src)
            => ref Unsafe.As<T,uint>(ref asRef(in src));

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref long int64<T>(in T src)
            => ref Unsafe.As<T,long>(ref asRef(in src));

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref ulong uint64<T>(in T src)
            => ref Unsafe.As<T,ulong>(ref asRef(in src));

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref float float32<T>(in T src)
            => ref Unsafe.As<T,float>(ref asRef(in src));

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.All)]
        public static ref double float64<T>(in T src)
            => ref Unsafe.As<T,double>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref char char16<T>(in T src)
            => ref Unsafe.As<T,char>(ref asRef(in src));        
 
        [MethodImpl(Inline)]
        public static ref T generic<T>(in sbyte src)
            => ref Unsafe.As<sbyte,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in byte src)
            => ref Unsafe.As<byte,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in short src)
            => ref Unsafe.As<short,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in ushort src)
            => ref Unsafe.As<ushort,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in int src)
            => ref Unsafe.As<int,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in uint src)
            => ref Unsafe.As<uint,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in long src)
            => ref Unsafe.As<long,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in ulong src)
            => ref Unsafe.As<ulong,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in float src)
            => ref Unsafe.As<float,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in double src)
            => ref Unsafe.As<double,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in char src)
            => ref Unsafe.As<char,T>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref T generic<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref asRef(in src));
    }
}