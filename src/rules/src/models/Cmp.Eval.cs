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
        public readonly struct CmpEval<T>
        {
            /// <summary>
            /// The evaluated predicate
            /// </summary>
            public CmpPred<T> Pred {get;}

            /// <summary>
            /// The evaluation result
            /// </summary>
            public bit Eval {get;}

            [MethodImpl(Inline)]
            public CmpEval(CmpPred<T> pred, bit eval)
            {
                Pred = pred;
                Eval = eval;
            }

            public string Format()
                => CmpPreds.format(this);

            public override string ToString()
                => Format();
        }
    }
}