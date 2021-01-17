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
    /// Captures the operands and outcome unary pair evaluation
    /// </summary>
    /// <typeparam name="T">The evaluation result type</typeparam>
    public readonly ref struct UnaryEvaluations<T>
        where T : unmanaged
    {
        /// <summary>
        /// The source operand data
        /// </summary>
        public readonly Span<T> Source;

        /// <summary>
        /// The evaluation data
        /// </summary>
        public readonly PairEvalResults<T> Target;

        [MethodImpl(Inline)]
        public UnaryEvaluations(Span<T> src, in PairEvalResults<T> dst)
        {
            Source = src;
            Target = dst;
        }

        /// <summary>
        /// The evaluated pair count
        /// </summary>
        public int Count
        {
            [MethodImpl(Inline)]
            get => Source.Length;
        }

        /// <summary>
        /// Designates the left operator
        /// </summary>
        public string LeftLabel
        {
            [MethodImpl(Inline)]
            get => Target.LeftLabel;
        }

        /// <summary>
        /// Designates the right operator
        /// </summary>
        public string RightLabel
        {
            [MethodImpl(Inline)]
            get => Target.RightLabel;
        }
    }
}