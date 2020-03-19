//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public readonly ref struct UnaryEval<T>
        where T : unmanaged
    {
        public readonly Span<T> Source;

        public readonly string LeftLabel;

        public readonly string RightLabel;

        public readonly Pairs<T> Target;        
        
        [MethodImpl(Inline)]
        public UnaryEval(Span<T> src, string leftLabel, string rightLabel, in Pairs<T> dst)
        {
            this.Source = src;
            this.LeftLabel = leftLabel;
            this.RightLabel = rightLabel;
            this.Target = dst;
        }        

        public int Count => Source.Length;
    }

}