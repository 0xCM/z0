//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Evaluator(typeof(EQ<>))]
    readonly struct EqEval<T> : IEvaluator<EQ<T>, CmpEval<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public bool Eval(in EQ<T> src, out CmpEval<T> dst)
        {
            dst = (src, gmath.eq(src.A,src.B));
            return true;
        }
    }

    [Evaluator(typeof(NEQ<>))]
    readonly struct NeqEval<T> : IEvaluator<NEQ<T>, CmpEval<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public bool Eval(in NEQ<T> src, out CmpEval<T> dst)
        {
            dst = (src, gmath.neq(src.A,src.B));
            return true;
        }
    }

    [Evaluator(typeof(GT<>))]
    readonly struct GtEval<T> : IEvaluator<GT<T>, CmpEval<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public bool Eval(in GT<T> src, out CmpEval<T> dst)
        {
            dst = (src, gmath.gt(src.A,src.B));
            return true;
        }
    }

    [Evaluator(typeof(GE<>))]
    readonly struct GteEval<T> : IEvaluator<GE<T>, CmpEval<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public bool Eval(in GE<T> src, out CmpEval<T> dst)
        {
            dst = (src, gmath.gteq(src.A,src.B));
            return true;
        }
    }

    [Evaluator(typeof(LT<>))]
    readonly struct LtEval<T> : IEvaluator<LT<T>, CmpEval<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public bool Eval(in LT<T> src, out CmpEval<T> dst)
        {
            dst = (src, gmath.lt(src.A,src.B));
            return true;
        }
    }

    [Evaluator(typeof(LE<>))]
    readonly struct LteEval<T> : IEvaluator<LE<T>, CmpEval<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public bool Eval(in LE<T> src, out CmpEval<T> dst)
        {
            dst = (src,gmath.lteq(src.A,src.B));
            return true;
        }
    }
}