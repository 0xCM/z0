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

    partial struct Blit
    {
        public readonly ref struct FunctionSpec
        {
            public readonly ReadOnlySpan<byte> Domain;

            public readonly ReadOnlySpan<byte> Range;

            [MethodImpl(Inline)]
            public FunctionSpec(ReadOnlySpan<byte> src, ReadOnlySpan<byte> dst)
            {
                Domain = src;
                Range = dst;
            }
        }

        public readonly ref struct FunctionSpec<S,T>
            where S : unmanaged
            where T : unmanaged
        {
            public readonly ReadOnlySpan<S> Source;

            public readonly ReadOnlySpan<T> Target;

            public FunctionSpec(in FunctionSpec src)
            {
                Source = recover<S>(src.Domain);
                Target = recover<T>(src.Range);
            }

            [MethodImpl(Inline)]
            public static implicit operator FunctionSpec<S,T>(FunctionSpec src)
                => new FunctionSpec<S,T>(src);
        }
    }
}