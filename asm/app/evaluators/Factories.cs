//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Check
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static EvalPackages;

    using C = Classes;

    public static partial class EvalPackages
    {

    }

    public static class Evaluation
    {            
        public static BinaryEval<T> Evaluate<T>(this IAsmContext context, 
            in BufferSeq execBuffers, Pair<T>[] sourceBuffer, Pair<T>[] targetBuffer, 
            in ApiMemberCode code,  C.BinaryOp<T> k)
                where T : unmanaged
        {
            var count = sourceBuffer.Length;
            var source = context.Random.Pairs<T>(sourceBuffer);
            var target =  PairEval.Define(("method", "asm"), Tuples.index(targetBuffer));
            var content = Evaluations.binary(source, target);
            var package = new BinaryOpPackage<T>(ApiEvalContext.Define(execBuffers, code), content);
            var evaluator = new BinaryOpEvaluator<T>(context);
            return evaluator.Evaluate(package);
        }

        public static BinaryEval<T> Evaluate<T>(this IAsmContext context, in BufferSeq buffers, in ApiMemberCode code, C.BinaryOp<T> @class)
            where T : unmanaged
                => context.Evaluate(buffers, new Pair<T>[100], new Pair<T>[100], code, @class);
    }
}