//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static EvalPackages;

    using C = Kinds;

    public static partial class EvalPackages
    {

    }

    public static class Evaluation
    {            
        static BinaryEval<T> Evaluate<T>(this IRandomContext context, 
            in BufferSeq execBuffers, Pair<T>[] sourceBuffer, Pair<T>[] targetBuffer, 
            in ApiMemberCode code,  C.BinaryOpClass<T> k)
                where T : unmanaged
        {
            var count = sourceBuffer.Length;
            var source = context.Random.Pairs<T>(sourceBuffer);
            var target =  Evaluations.pairs(("method", "asm"), Tuples.index(targetBuffer));
            var content = Evaluations.binary(source, target);
            var package = new BinaryOpPackage<T>(ApiEvalContext.Define(execBuffers, code), content);
            var evaluator = new BinaryOpEvaluator<T>();
            return evaluator.Evaluate(package);
        }

        public static BinaryEval<T> Evaluate<T>(this IRandomContext context, in BufferSeq buffers, in ApiMemberCode code, C.BinaryOpClass<T> @class)
            where T : unmanaged
                => context.Evaluate(buffers, new Pair<T>[100], new Pair<T>[100], code, @class);

        public static MemberEvaluator Evaluator<E,T>(this IRandomContext context, in BufferSeq buffers, IOpClass<E,T> k)
            where T : unmanaged
            where E : unmanaged, Enum
                => MemberEvaluator.Create(context, context.Random, buffers);
    }
}