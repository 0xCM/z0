//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Tuples;

    public readonly ref struct UnaryEval<T>
        where T : unmanaged
    {
        public readonly Span<T> Source;

        public readonly PairEval<T> Target;        
        
        [MethodImpl(Inline)]
        public UnaryEval(Span<T> src, in PairEval<T> dst)
        {
            this.Source = src;
            this.Target = dst;
        }        

        public string LeftLabel 
            => Target.LeftLabel;

        public string RightLabel 
            => Target.RightLabel;

        public int Count 
            => Source.Length;
    }
}