//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures the operands and outcome of binary operator evaluation
    /// </summary>
    /// <typeparam name="T">The evaluation result type</typeparam>
    public readonly ref struct BinaryEvaluations<T>
        where T : unmanaged
    {
        public Pairs<T> Source {get;}

        public readonly PairEvalResults<T> Target;

        [MethodImpl(Inline)]
        public BinaryEvaluations(in Pairs<T> src, PairEvalResults<T> dst)
        {
            root.require(src.PointCount == dst.PointCount, () => "no");
            Source = src;
            Target = dst;
        }

        public uint PointCount
            => Source.PointCount;

        public ref Pair<T> First
        {
            [MethodImpl(Inline)]
            get => ref Target.First;
        }

        public ref Pair<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Target[index];
        }

        public string LeftLabel
            => Target.LeftLabel;

        public string RightLabel
            => Target.RightLabel;
    }
}