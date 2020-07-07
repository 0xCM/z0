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
    /// Captures the operands and outcome of binary operator evaluation 
    /// </summary>
    /// <typeparam name="T">The evaluation result type</typeparam>
    public readonly ref struct BinaryEvaluations<T>
        where T : unmanaged
    {
        public readonly Pairs<T> Source;

        public readonly PairEvalOutcomes<T> Target;
                
        [MethodImpl(Inline)]
        internal BinaryEvaluations(in Pairs<T> src, PairEvalOutcomes<T> dst)
        {
            Demands.insist(src.PointCount, dst.PointCount);
            Source = src;
            Target = dst;
        }        

        public int PointCount 
            => Source.PointCount;

        public string LeftLabel 
            => Target.LeftLabel;

        public string RightLabel 
            => Target.RightLabel;
    }
}