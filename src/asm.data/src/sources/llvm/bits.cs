//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct bits<M,T>
        where M : unmanaged, ITypeNat
        where T : unmanaged
    {
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

    public struct bits<T>
        where T : unmanaged
    {
        public T Packed;

        public uint N;

        [MethodImpl(Inline)]
        public bits(uint n, T src)
        {
            N = n;
            Packed = src;
        }

        [MethodImpl(Inline)]
        public static implicit operator bits<T>((uint n, T value) src)
            => new bits<T>(src.n, src.value);
    }

    public readonly struct bits
    {
        [MethodImpl(Inline)]
        public static bits<N,T> value<N,T>(N n, T value)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new bits<N,T>(value);

        [MethodImpl(Inline)]
        public static bits<T> value<T>(uint n, T value)
            where T : unmanaged
                => new bits<T>(n, value);
    }
}