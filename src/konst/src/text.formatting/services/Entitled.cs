//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Entitled<C> : IEntitled<C>
    {
        public readonly TitleFormatter<C> TitleFormatter;

        public readonly Formatter<C> ContentFormatter;

        [MethodImpl(Inline)]
        public Entitled(TitleFormatter<C> entitle, Formatter<C> formatter)
        {
            ContentFormatter = formatter;
            TitleFormatter = entitle;
        }

        ITextFormatter<C> IEntitled<C>.ContentFormatter
            => ContentFormatter;

        ITitleFormatter<C> IEntitled<C>.TitleFormatter
            => TitleFormatter;
    }
}