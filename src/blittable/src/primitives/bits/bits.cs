//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitFlow
    {
        [MethodImpl(Inline)]
        public static bits<N,T> nbits<N,T>(N n, T value)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new bits<N,T>(value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bits<T> nbits<T>(uint n, T value)
            where T : unmanaged
                => new bits<T>(n, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit element<T>(in bits<T> src, uint index)
            where  T : unmanaged
        {
            var data = bytes(src.Packed);
            ref readonly var cell = ref skip(data,index/8);
            return bit.test(cell, (byte)(index % 8));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void convert<T>(bits<T> src, list<bit> dst)
            where T : unmanaged
        {
            for(var i=0u; i<src.N; i++)
                dst[i] = element(src,i);
        }

        public struct bits<T>
            where T : unmanaged
        {
            public const string Identifier = "bits<{0}>";

            public static ByteSize SZ => size<T>();

            public T Packed;

            public uint N;

            public string TypeName
                => string.Format(Identifier, N);

            [MethodImpl(Inline)]
            public bits(uint n, T src)
            {
                N = n;
                Packed = src;
            }

            public bit this[uint index]
            {
                [MethodImpl(Inline)]
                get => element(this,index);
            }

            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator bits<T>((uint n, T value) src)
                => new bits<T>(src.n, src.value);
        }

       public struct bits<M,T>
            where M : unmanaged, ITypeNat
            where T : unmanaged
        {
            public static ByteSize SZ => size<T>();

            public T Packed;

            [MethodImpl(Inline)]
            public bits(T src)
            {
                Packed = src;
            }

            public uint N
            {
                [MethodImpl(Inline)]
                get => Typed.nat32u<M>();
            }

            [MethodImpl(Inline)]
            public static implicit operator bits<M,T>(T src)
                => new bits<M,T>(src);
        }
    }
}