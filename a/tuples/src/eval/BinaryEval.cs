//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Tuples;

    public readonly ref struct BinaryEval<T>
        where T : unmanaged
    {
        public readonly Pairs<T> Source;

        public readonly PairEval<T> Target;
                
        [MethodImpl(Inline)]
        public BinaryEval(in Pairs<T> src, PairEval<T> dst)
        {
            this.Source = src;
            this.Target = dst;
        }        

        public int Count => Source.Count;

        public string LeftLabel => Target.LeftLabel;

        public string RightLabel => Target.RightLabel;
    }
}