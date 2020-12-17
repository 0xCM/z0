//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public ref struct BinaryBitLogixCheck
    {
        ReadOnlySpan<bit> A;

        ReadOnlySpan<bit> B;

        uint Count;

        BinaryBitLogicKind Kind;

        Func<bit,bit,bit> Rule;

        SeqEval<bit> Result;

        BitLogix Service;

        readonly IWfShell Wf;

        [MethodImpl(Inline), Op]
        internal BinaryBitLogixCheck(IWfShell wf)
            : this()
        {
            Wf = wf;
        }

        [Op]
        public static BinaryBitLogixCheck create(IWfShell wf, BinaryBitLogicKind kind, Func<bit,bit,bit> rule, uint count, IPolyStream source)
        {
            var dst = new BinaryBitLogixCheck(wf);
            dst.Kind = kind;
            dst.Rule = rule;
            dst.Count = count;
            dst.A = source.BitStream().Take(dst.Count).Array();
            dst.B = source.BitStream().Take(dst.Count).Array();
            dst.Result = EvalSeq.alloc<bit>(dst.Count,true);
            dst.Service = BitLogix.Service;
            return dst;
        }

        [Op]
        ref BinaryEval<bit> Check(in bit a, in bit b, ref BinaryEval<bit> dst)
        {
            var expect = Rule(a, b);
            var actual = Service.Evaluate(Kind, a, b);
            var result = expect == actual;
            dst = new BinaryEval<bit>(a, b, result);
            return ref dst;
        }

        [Op]
        public SeqEval<bit> Run()
        {
            var dst = Result;
            var service = BitLogix.Service;
            var target = dst.Edit;
            ref var result = ref dst.Result;
            for(var i=0u; i<Count; i++)
            {
                ref readonly var a = ref skip(A,i);
                ref readonly var b = ref skip(B,i);
                ref var judgement = ref Check(a,b, ref seek(target,i));
                result &= judgement.Result;
            }
            return Result;
        }
    }
}