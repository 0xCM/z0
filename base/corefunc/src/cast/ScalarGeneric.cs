//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    public static partial class AsIn
    {
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
        public static ref T generic<T>(in decimal src)
            => ref Unsafe.As<decimal,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in char src)
            => ref Unsafe.As<char,T>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref T generic<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref asRef(in src));

    }

    public static partial class As
    {
        [MethodImpl(Inline)]
        public static T generic<T>(sbyte src)
            => Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref sbyte src)
            => ref Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(byte src)
            => Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref byte src)
            => ref Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(short src)
            => Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref short src)
            => ref Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(ushort src)
            => Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref ushort src)
            => ref Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(int src)
            => Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref int src)
            => ref Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(uint src)
            => Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref uint src)
            => ref Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(long src)
            => Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(ulong src)
            => Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref long src)
            => ref Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref ulong src)
            => ref Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(float src)
            => Unsafe.As<float,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(double src)
            => Unsafe.As<double,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(char src)
            => Unsafe.As<char,T>(ref src); 

    }


}