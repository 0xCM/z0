//-----------------------------------------------------------------------------
// Copyright   :  (c) LLVM Project
// License     :  Apache-2.0 WITH LLVM-exceptions
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Types
    {
        public struct bits<T>
            where T : unmanaged
        {
            public const string Identifier = "bits<{0}>";

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

            [MethodImpl(Inline)]
            public static implicit operator bits<T>((uint n, T value) src)
                => new bits<T>(src.n, src.value);
        }

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
    }
}