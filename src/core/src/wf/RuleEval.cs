//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct RuleEval
    {
        public delegate bool Evaluator<S,T>(in S src, out T dst);

        public static uint eval<S,T>(ReadOnlySpan<S> src, Span<T> dst, Evaluator<S,T> f)
        {
            var count = min(src.Length, dst.Length);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                if(f(skip(src,i), out seek(dst,i)))
                    counter++;
                else
                    break;
            }
            return counter;
        }

        public static uint eval<S,T>(ReadOnlySpan<S> src, Span<T> dst, IEvaluator<S,T> f)
        {
            var count = min(src.Length, dst.Length);
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                if(f.Eval(skip(src,i), out seek(dst,i)))
                    counter++;
                else
                    break;
            }
            return counter;
        }
    }
}