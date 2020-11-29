//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XBitSpans
    {
        [MethodImpl(Inline)]
        public static BitSpan Concat(this BitSpan head, BitSpan tail)
            => BitSpans.concat(head,tail);
    }
}