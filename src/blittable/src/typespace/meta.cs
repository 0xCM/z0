//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace types
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using Z0;

    using static Z0.core;
    using static Z0.Root;

    using traits;

    namespace meta
    {
        public struct name
        {
            public CharBlock64 Value;

            [MethodImpl(Inline)]
            public name(CharBlock64 src)
            {
                Value = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator name(CharBlock64 src)
                => new name(src);

            [MethodImpl(Inline)]
            public static implicit operator CharBlock64(name src)
                => src.Value;
        }

        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct literal<V>
        {
            public name Name;

            public LiteralKind Kind;

            public V Value;

            [MethodImpl(Inline)]
            public literal(name n, LiteralKind kind, V value)
            {
                Name = n;
                Kind = kind;
                Value = value;
            }
        }

        public struct i<S> : Integral<S>
            where S : unmanaged
        {
            public S Storage;

            public uint N;

            [MethodImpl(Inline)]
            public i(S src, uint n)
            {
                Storage = src;
                N = n;
            }
            uint Scalar.N
                => N;

            S Type<S>.Storage
                => Storage;
        }

        public struct block<T>
            where T : unmanaged
        {
            T Storage;
        }

        public struct grid<T>
            where T : unmanaged
        {

        }
    }
}