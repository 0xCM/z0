//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Captures a comparison predicate along with its evaluation
        /// </summary>
        public readonly struct CmpEval<T> : IEvaluation<CmpPred<T>,bit>
        {
            /// <summary>
            /// The evaluated predicate
            /// </summary>
            public CmpPred<T> Source {get;}

            /// <summary>
            /// The evaluation result
            /// </summary>
            public bit Result {get;}

            [MethodImpl(Inline)]
            public CmpEval(CmpPred<T> pred, bit eval)
            {
                Source = pred;
                Result = eval;
            }

            public string Format()
                => CmpPreds.format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator CmpEval<T>((CmpPred<T> src, bit result) x)
                => new CmpEval<T>(x.src, x.result);
        }
    }
}