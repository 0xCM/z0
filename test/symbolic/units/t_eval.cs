//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct EvalDriver
    {
        IEvaluator Evaluator {get;}

        public static Outcome<dynamic> untype<R>(Outcome<R> src)
        {
            if(src)
            {
                return (true, src.Data, src.Message);
            }
            else
            {
                return (false, src.Message);
            }

        }

        public Outcome<Index<Paired<uint,bool>>> Evaluate(ReadOnlySpan<dynamic> src, Span<dynamic> dst)
        {
            try
            {
                var count = root.min(src.Length, dst.Length);
                Index<Paired<uint,bool>> results = sys.alloc<Paired<uint,bool>>(count);
                ref var outcome = ref results.First;
                var wins = 0;
                var fails = 0;
                for(var i=0u; i<count; i++)
                {
                    Outcome<dynamic> eval = Evaluator.Evaluate(skip(src,i));
                    if(eval)
                    {
                        seek(dst,i) = eval.Data;
                        seek(outcome,i) = root.paired(i,true);
                    }
                    else
                    {
                        seek(outcome,i) = root.paired(i,false);
                    }

                }
                return results;
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }

    public interface IEvaluator
    {
        Outcome<dynamic> Evaluate(params dynamic[] src);
    }

    public interface IKindedEvaluator : IEvaluator
    {
        ApiClassKind Class {get;}
    }

    public interface IKindedEvaluator<K> : IKindedEvaluator
        where K : unmanaged, IApiKind
    {
        ApiClassKind IKindedEvaluator.Class
            => (default(K) as IApiKind).ClassId;
    }


    public interface IEvaluator<R> : IEvaluator
    {
        Outcome<R> Evaluate(dynamic src);

        Outcome<dynamic> IEvaluator.Evaluate(params dynamic[] src)
            => EvalDriver.untype(Evaluate(src));
    }

    public interface IEvaluator<A,R> : IEvaluator
    {
        Outcome<R> Evaluate(A src);

        Outcome<dynamic> IEvaluator.Evaluate(params dynamic[] src)
            => EvalDriver.untype(Evaluate(src));
    }

    public interface IEvaluator<A,B,R> : IEvaluator
    {
        Outcome<R> Evaluate(A a, B b);

        Outcome<dynamic> IEvaluator.Evaluate(params dynamic[] src)
            => EvalDriver.untype(Evaluate(src[0], src[1]));
    }


    public interface IUniformEvaluator<A> : IEvaluator<A,A,A>
    {

    }

    public interface IKindedUniformEvaluator<K,A> : IUniformEvaluator<A>, IKindedEvaluator<K>
        where K : unmanaged, IApiKind
    {

    }

    public readonly struct PrimalXorEvaluator<A> : IKindedUniformEvaluator<ApiClasses.Xor,A>
        where A : unmanaged
    {
        [MethodImpl(Inline)]
        public Outcome<A> Evaluate(A a, A b)
            => gmath.xor(a,b);
    }

    public readonly struct PrimalAndEvaluator<A> : IUniformEvaluator<A>, IKindedEvaluator<ApiClasses.And>
        where A : unmanaged
    {
        [MethodImpl(Inline)]
        public Outcome<A> Evaluate(A a, A b)
            => gmath.and(a,b);
    }

    public class t_eval : t_symbolic<t_eval>
    {
        public void check_sigs()
        {
            //var methods = typeof(cpu).Methods().OfKind(ApiClass.And);
            var methods = typeof(cpu).Methods().Kinded();

            using var writer = CaseWriter(LogExt);
            foreach(var m in methods)
            {
                var artifact = m.Artifact();


            }

                //writer.WriteLine(m.Metadata().DisplaySig);
        }
    }
}
