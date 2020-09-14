//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ClrArtifacts
    {
        public readonly ref struct Artifacts<A>
            where A : struct, IClrArtifact<A>
        {
            readonly ReadOnlySpan<A> Data;

            [MethodImpl(Inline)]
            public static implicit operator Artifacts<A>(Span<A> src)
                => new Artifacts<A>(src);

            [MethodImpl(Inline)]
            public static implicit operator Artifacts<A>(A[] src)
                => new Artifacts<A>(src);

            [MethodImpl(Inline)]
            public static implicit operator Artifacts<A>(ReadOnlySpan<A> src)
                => new Artifacts<A>(src);

            [MethodImpl(Inline)]
            public static implicit operator ReadOnlySpan<A>(Artifacts<A> src)
                => src.Data;

            [MethodImpl(Inline)]
            public Artifacts(A[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public Artifacts(Span<A> src)
                => Data = src;

            [MethodImpl(Inline)]
            public Artifacts(ReadOnlySpan<A> src)
                => Data = src;

            public ref readonly A this[ulong i]
            {
                [MethodImpl(Inline)]
                get => ref skip(Data,i);
            }

            public ref readonly A this[long i]
            {
                [MethodImpl(Inline)]
                get => ref skip(Data,i);
            }

            public uint Count
            {
                [MethodImpl(Inline)]
                get => (uint)Data.Length;
            }

            public int Length
            {
                [MethodImpl(Inline)]
                get => Data.Length;
            }

            public ref readonly A First
            {
                [MethodImpl(Inline)]
                get => ref first(Data);
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Data.Length == 0;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Data.Length != 0;
            }
        }
    }
}