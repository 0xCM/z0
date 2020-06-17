//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures paired evaluations
    /// </summary>
    /// <typeparam name="T">The evaluation result type</typeparam>
    public readonly ref struct PairEval<T>
        where T : unmanaged
    {
        public readonly Pair<string> Labels;
        
        public readonly Pairs<T> Target;     
           
        [MethodImpl(Inline)]
        public PairEval(Pair<string> labels, in Pairs<T> target)
        {
            Labels = labels;
            Target = target;
        }        

        public string LeftLabel 
        {
            [MethodImpl(Inline)]
            get => Labels.Left;
        }

        public string RightLabel 
        {
            [MethodImpl(Inline)]
            get => Labels.Right;
        }
    }
}