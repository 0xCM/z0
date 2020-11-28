//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ValueSource<T> : IValueSource<T>
        where T : struct
    {
        readonly IValueSource Source;

        [MethodImpl(Inline)]
        public ValueSource(IValueSource source)
            => Source = source;

        [MethodImpl(Inline)]
        public void Fill(Span<T> dst)
            => Source.Fill(dst);

        public T Next()
            => Source.Next<T>();
    }
}