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
    public readonly ref struct PairEvalOutcomes<T>
        where T : unmanaged
    {
        readonly Pair<string> Labels;
        
        readonly Pairs<T> Target;     
           
        [MethodImpl(Inline)]
        public PairEvalOutcomes(Pair<string> labels, in Pairs<T> target)
        {
            Labels = labels;
            Target = target;
        }        

        [MethodImpl(Inline)]
        public ref Pair<T> Pair(int index)
            => ref Target[index];

        public ref Pair<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Pair(index);
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Target.Count;
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