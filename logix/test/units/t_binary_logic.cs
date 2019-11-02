//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static BitLogicSpec;
    using static LogicEngine;
    using BL = BinaryLogicOpKind;

    public class t_binary_logic : UnitTest<t_binary_logic>
    {
        protected override int CycleCount => Pow2.T08;
                
        public void and_op_check()
            => logic_op_check(BL.And, (a,b) => a & b);

        public void and_expr_check()
            => logic_expr_check(BL.And, LogicOps.and);

        public void nand_op_check()
            => logic_op_check(BL.Nand, (a,b) => !(a & b));

        public void nand_expr_check()
            => logic_expr_check(BL.Nand, LogicOps.nand);

        public void or_op_check()
            => logic_op_check(BL.Or, (a,b) => a | b);

        public void or_expr_check()
            => logic_expr_check(BL.Or, LogicOps.or);

        public void nor_op_check()
            => logic_op_check(BL.Nor, (a,b) => !(a | b));

        public void nor_expr_check()
            => logic_expr_check(BL.Nor, LogicOps.nor);

        public void xor_op_check()
            => logic_op_check(BL.XOr, (a,b) => a ^ b);

        public void xor_expr_check()
            => logic_expr_check(BL.XOr, LogicOps.xor);

        public void xnor_op_check()
            => logic_op_check(BL.Xnor, (a,b) => !(a ^ b));

        public void xnor_expr_check()
            => logic_expr_check(BL.Xnor, LogicOps.xnor);

        public void t_bitcombo_check()
        {
            Claim.eq(Pow2.T01, bitcombo(n1).Distinct().Count());
            Claim.eq(Pow2.T02, bitcombo(n2).Distinct().Count());
            Claim.eq(Pow2.T03, bitcombo(n3).Distinct().Count());
            Claim.eq(Pow2.T04, bitcombo(n4).Distinct().Count());
            Claim.eq(Pow2.T05, bitcombo(n5).Distinct().Count());
            Claim.eq(Pow2.T06, bitcombo(n6).Distinct().Count());
            Claim.eq(Pow2.T07, bitcombo(n7).Distinct().Count());
            Claim.eq(Pow2.T08, bitcombo(n8).Distinct().Count());
        }

        void bitcombo_emit()
        {
            var width = n8;
            var terms = bitcombo(width).Select(x => x.Terms).SelectMany(x => x).ToSpan();
            var expectations = terms.ToBitString().Pack().AsUInt64();
            var matrix = BitMatrix.alloc<ulong>();
            
            for(int i=0, j=0; i< terms.Length; i+= 64, j++)
            {
                var actual = gbits.pack<ulong>(terms.Slice(i));
                BitVector<ulong> expect = expectations[j];
                Claim.eq(actual,expect);
                matrix[j] = actual;
            
                Trace(actual.Format(blockWidth: 8));
            }
            
        }

        public void t_bitseq_check()
        {
            for(var sample=0; sample<SampleSize; sample++)          
            {
                var bs = Random.BitString(2,7);
                var x = LiteralLogicSeq.FromBitString(bs);
                var y = BitVector8.FromBitString(bs);
                for(var i=0; i<bs.Length; i++)
                {
                    Claim.eq(bs[i],x[i]);
                    Claim.eq(bs[i],y[i]);
                }
            }
        }

        public void logic_op_bench()
        {
            logic_op_bench(true);
            logic_op_bench(false);
        }

        void logic_op_check(BL kind, Func<bit,bit,bit> rule)
        {
            var lhsBits = Random.BitSpan(SampleSize);
            var rhsBits = Random.BitSpan(SampleSize);
            for(var i=0; i<SampleSize; i++)
            {
                var a = lhsBits[i];
                var b = rhsBits[i];
                var expect = rule(a,b);
                var actual = LogicOpApi.eval(kind, a,b);
                Claim.eq(expect, actual);
            }

        }

        void logic_expr_check(BL kind, Func<bit,bit,bit> rule)
        {
            var v1 = variable(1);
            var v2 = variable(2);
            var expr = binary(kind, v1,v2);

            foreach(var seq in bitcombo(n2)) 
            {
                var s1 = seq[0];
                var s2 = seq[1];
                v1.Set(s1);
                v2.Set(s2);
                var expect = rule(s1,s2);
                var e1 = eval(expr);
                Claim.eq(expect,e1);
            }
        }

        void logic_op_bench(bool lookup, SystemCounter clock = default)
        {
            var opname = $"ops/logical/lookup[{lookup}]";

            var lhsSamples = Random.Bits().Take(SampleSize).ToArray();
            var rhsSamples = Random.Bits().Take(SampleSize).ToArray();
            var result = bit.Off;
            var kinds = LogicOpApi.BinaryOpKinds;
            var opcount = 0;

            clock.Start();

            if(lookup)
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleSize; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                    result = LogicOpApi.lookup(kinds[k])(lhsSamples[sample], rhsSamples[sample]);
            }
            else
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleSize; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                    result = LogicOpApi.eval(kinds[k],lhsSamples[sample], rhsSamples[sample]);
            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }

    }
}