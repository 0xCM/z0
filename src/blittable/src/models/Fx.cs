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
        public readonly ref struct Fx
        {
            public readonly ReadOnlySpan<byte> Domain;

            public readonly ReadOnlySpan<byte> Range;

            [MethodImpl(Inline)]
            public Fx(ReadOnlySpan<byte> src, ReadOnlySpan<byte> dst)
            {
                Domain = src;
                Range = dst;
            }
        }

        public readonly ref struct Fx<S,T>
            where S : unmanaged
            where T : unmanaged
        {
            public readonly ReadOnlySpan<S> Source;

            public readonly ReadOnlySpan<T> Target;

            public Fx(in Fx src)
            {
                Source = recover<S>(src.Domain);
                Target = recover<T>(src.Range);
            }

            [MethodImpl(Inline)]
            public static implicit operator Fx<S,T>(Fx src)
                => new Fx<S,T>(src);
        }
    }
}