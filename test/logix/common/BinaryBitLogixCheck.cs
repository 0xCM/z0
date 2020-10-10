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

    [ApiHost(ApiNames.BinaryBitLogixCheck,true)]
    public ref struct BinaryBitLogixCheck
    {
        ReadOnlySpan<Bit32> A;

        ReadOnlySpan<Bit32> B;

        uint Count;

        BinaryBitLogicKind Kind;

        Func<Bit32,Bit32,Bit32> Rule;

        SequenceJudgement<Bit32> Result;

        BitLogix Service;

        readonly IWfShell Wf;

        [MethodImpl(Inline), Op]
        BinaryBitLogixCheck(IWfShell wf)
            : this()
        {
            Wf = wf;
        }


        [Op, MethodImpl(NotInline)]
        public static BinaryBitLogixCheck create(BinaryBitLogicKind kind, Func<Bit32,Bit32,Bit32> rule, uint count, IPolySourced source)
        {
            var dst = new BinaryBitLogixCheck();
            dst.Kind = kind;
            dst.Rule = rule;
            dst.Count = count;
            dst.A = source.BitStream32().Take(dst.Count).Array();
            dst.B = source.BitStream32().Take(dst.Count).Array();
            dst.Result = SequenceJudgement.alloc<Bit32>(dst.Count,true);
            dst.Service = BitLogix.Service;
            return dst;
        }

        [Op, MethodImpl(NotInline)]
        ref BinaryJudgement<Bit32> Check(in Bit32 a, in Bit32 b, ref BinaryJudgement<Bit32> dst)
        {
            var expect = Rule(a, b);
            var actual = Service.Evaluate(Kind, a, b);
            var result = expect == actual;
            dst = Judgements.binary(a, b, result);
            return ref dst;
        }

        [Op, MethodImpl(NotInline)]
        public SequenceJudgement<Bit32> Run()
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
                result &= judgement.Success;
            }
            return Result;
        }
    }
}