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
        public readonly struct CmpEval<T>
            where T : ICmpPred
        {
            public T Pred {get;}

            public bit Eval {get;}

            [MethodImpl(Inline)]
            public CmpEval(T pred, bit eval)
            {
                Pred = pred;
                Eval = eval;
            }

            public string Format()
                => string.Format("{0}={1}", Pred.Format(), Eval);

            public override string ToString()
                => Format();
        }
    }
}