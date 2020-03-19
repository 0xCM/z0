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
        public static BinaryOpPackage<T> Package<T>(this in ApiEvalContext context, in PairEval<T> content, C.BinaryOp<T> @class)
            where T : unmanaged
                => new BinaryOpPackage<T>(context, content);

    }

    public static class Evaluators
    {
        public static IBinaryOpEvaluator<T> Evaluator<T>(this IAsmWorkflowContext context, C.BinaryOp<T> @class)
            where T : unmanaged
                => new BinaryOpEvaluator<T>(context);        
    }

    public static class Evaluation
    {            
        public static PairEval<T> Evaluate<T>(this IAsmWorkflowContext workflow, in BufferSeq buffers, in ApiMemberCode code, 
            Pair<T>[] sourceBuffer, Pair<T>[] targetBuffer,  C.BinaryOp<T> k)
                where T : unmanaged
        {
            var count = sourceBuffer.Length;
            var context = ApiEvalContext.Define(buffers, code);
            var source = workflow.Random.Pairs<T>(sourceBuffer);
            var target = Tuples.index(targetBuffer);
            var content = Tuples.eval(source, "method", "asm", target);
            var package = context.Package(content, k);
            var evaluator = workflow.Evaluator(k);
            return evaluator.Evaluate(package);
        }

        public static PairEval<T> Evaluate<T>(this IAsmWorkflowContext workflow, in BufferSeq buffers, in ApiMemberCode code, C.BinaryOp<T> @class)
            where T : unmanaged
                => workflow.Evaluate(buffers, code, new Pair<T>[100], new Pair<T>[100], @class);
    }
}