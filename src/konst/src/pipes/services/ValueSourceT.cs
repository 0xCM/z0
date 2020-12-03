//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ValueSource<T> : ISource<T>
        where T : struct
    {
        readonly ISource Source;

        [MethodImpl(Inline)]
        public ValueSource(ISource source)
            => Source = source;

        [MethodImpl(Inline)]
        public void Fill(Span<T> dst)
            => Source.Fill(dst);

        public T Next()
            => Source.Next<T>();
    }
}