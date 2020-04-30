//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Tuples;

    /// <summary>
    /// Captures paired evaluations
    /// </summary>
    public readonly ref struct PairEval<T>
        where T : unmanaged
    {
        public readonly Pair<string> Labels;
        
        public readonly Pairs<T> Target;     
           
        [MethodImpl(Inline)]
        public PairEval(Pair<string> labels, in Pairs<T> target)
        {
            this.Labels = labels;
            this.Target = target;
        }        

        public string LeftLabel => Labels.Left;

        public string RightLabel => Labels.Right;
    }
}