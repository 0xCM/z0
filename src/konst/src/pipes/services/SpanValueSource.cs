//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SpanValueSource<T> : ISpanValueSource<T>
        where T : struct
    {
        readonly ISpanValueSource Source;

        [MethodImpl(Inline)]
        public SpanValueSource(ISpanValueSource provider)
            => Source = provider;

        [MethodImpl(Inline)]
        public void Fill(Span<T> dst)
            => Source.Fill(dst);
    }

    public readonly struct SpanValueSource
    {
        readonly ISpanValueSource Source;

        public SpanValueSource(ISpanValueSource provider)
            => Source = provider;

        [MethodImpl(Inline)]
        public void Fill<T>(Span<T> dst)
            where T : struct
                => Source.Fill(dst);
    }
}