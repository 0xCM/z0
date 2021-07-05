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

    partial struct Rules
    {
        public readonly ref struct ImmutableVecs<T>
        {
            readonly ReadOnlySpan<T> Data;

            public uint Count {get;}

            public uint Dim {get;}

            [MethodImpl(Inline)]
            public ImmutableVecs(ReadOnlySpan<T> src, uint count)
            {
                Data = src;
                Count = count;
                Dim = (uint)src.Length/count;
            }

            internal ReadOnlySpan<T> Storage
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public ImmutableVec<T> this[ulong index]
            {
                [MethodImpl(Inline)]
                get => vec(this, (uint)index);
            }

            public ImmutableVec<T> this[long index]
            {
                [MethodImpl(Inline)]
                get => vec(this, (uint)index);
            }
        }

    }
}