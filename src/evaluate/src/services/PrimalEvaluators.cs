//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Rules;

    public readonly struct PrimalEvaluators
    {

        [Evaluator(typeof(EQ<>))]
        readonly struct PrimalEqEval<T> : IEvaluator<EQ<T>, CmpEval<T>>
            where T : unmanaged
        {
            public bool Eval(in EQ<T> src, out CmpEval<T> dst)
            {
                dst = (src, gmath.eq(src.A,src.B));
                return true;
            }
        }

        [Evaluator(typeof(NEQ<>))]
        readonly struct PrimalNeqEval<T> : IEvaluator<NEQ<T>, CmpEval<T>>
            where T : unmanaged
        {
            public bool Eval(in NEQ<T> src, out CmpEval<T> dst)
            {
                dst = (src,gmath.neq(src.A,src.B));
                return true;
            }
        }

        [Evaluator(typeof(GT<>))]
        readonly struct PrimalGtEval<T> : IEvaluator<GT<T>, CmpEval<T>>
            where T : unmanaged
        {
            public bool Eval(in GT<T> src, out CmpEval<T> dst)
            {
                dst = (src, gmath.gt(src.A,src.B));
                return true;
            }
        }

        [Evaluator(typeof(GTE<>))]
        readonly struct PrimalGteEval<T> : IEvaluator<GTE<T>, CmpEval<T>>
            where T : unmanaged
        {
            public bool Eval(in GTE<T> src, out CmpEval<T> dst)
            {
                dst = (src, gmath.gteq(src.A,src.B));
                return true;
            }
        }

        [Evaluator(typeof(LT<>))]
        readonly struct PrimalLtEval<T> : IEvaluator<LT<T>, CmpEval<T>>
            where T : unmanaged
        {
            public bool Eval(in LT<T> src, out CmpEval<T> dst)
            {
                dst = (src, gmath.lt(src.A,src.B));
                return true;
            }
        }

        [Evaluator(typeof(LTE<>))]
        readonly struct PrimalLteEval<T> : IEvaluator<LTE<T>, CmpEval<T>>
            where T : unmanaged
        {
            public bool Eval(in LTE<T> src, out CmpEval<T> dst)
            {
                dst = (src,gmath.lteq(src.A,src.B));
                return true;
            }
        }
    }
}