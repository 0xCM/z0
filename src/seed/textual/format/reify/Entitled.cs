//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    readonly struct Entitled<C> : IEntitled<C>
    {
        public ITitleFormatter<C> TitleFormatter {get;}

        public IFormatter<C> ContentFormatter {get;}

        [MethodImpl(Inline)]
        public Entitled(ITitleFormatter<C> entitle, IFormatter<C> formatter)
        {
            ContentFormatter = formatter;
            TitleFormatter = entitle;
        }
    }
}