//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static z;

    using static BitLogicSpec;
    using static LogicEngine;
    using static BinaryBitLogicKind;

    using BLK = BinaryBitLogicKind;

    public abstract class LogixTest<X> : UnitTest<X,CheckVectorBits,ICheckVectorBits>
        where X : LogixTest<X>
    {
        BitLogix bitlogix => BitLogix.Service;

        protected void logic_expr_check(BLK kind, Func<bit,bit,bit> rule)
        {
            var v1 = lvar(1);
            var v2 = lvar(2);
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

        protected void logic_op_bench(bool lookup, SystemCounter clock = default)
        {
            var opname = $"ops/logical/lookup[{lookup}]";

            var lhsSamples = Random.BitStream32().Take(RepCount).ToArray();
            var rhsSamples = Random.BitStream32().Take(RepCount).ToArray();
            var result = Z0.bit.Off;
            var kinds = bitlogix.BinaryOpKinds;
            var opcount = 0;

            clock.Start();

            if(lookup)
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< RepCount; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                    result = bitlogix.Lookup(kinds[k])(lhsSamples[sample], rhsSamples[sample]);
            }
            else
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< RepCount; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                    result = bitlogix.Evaluate(kinds[k],lhsSamples[sample], rhsSamples[sample]);
            }

            clock.Stop();

            ReportBenchmark(opname, opcount,clock);
        }



        protected void bm_delegate_bench<T>(BinaryBitLogicKind opkind, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_{opkind.Format()}_{ApiIdentify.numeric<T>()}_delegate";
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;
            var Op = SquareBitLogix.lookup<T>(opkind);

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {
                Op(A, B, Z);
                opcount++;
                for(var sample=0; sample< RepCount; sample++)
                {
                    Op(Z, A, Z);
                    Op(B, Z, Z);
                    opcount +=2;
                }
            }

            clock.Stop();

            ReportBenchmark(opname, opcount, clock);
        }

        protected void bm_and_bench<T>(SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_and_{ApiIdentify.numeric<T>()}";

            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {
                SquareBitLogix.and(A, B, Z);
                opcount++;
                for(var sample=0; sample< RepCount; sample++)
                {
                    SquareBitLogix.and(Z, A, Z);
                    SquareBitLogix.and(B, Z, Z);
                    opcount +=2;
                }
            }

            clock.Stop();

            ReportBenchmark(opname, opcount, clock);
        }

        protected void bm_xor_bench<T>(SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_xor_{ApiIdentify.numeric<T>()}";

            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {
                SquareBitLogix.xor(A, B, Z);
                opcount++;
                for(var sample=0; sample< RepCount; sample++)
                {
                    SquareBitLogix.xor(Z, A, Z);
                    SquareBitLogix.xor(B, Z, Z);
                    opcount +=2;
                }
            }

            clock.Stop();

            ReportBenchmark(opname, opcount, clock);
        }

       protected void bitwise_logic_check<T>(BinaryBitLogicKind kind)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                var result1 = NumericLogixHost.eval(kind,a,b);
                var result2 = BitVectorLogix.Service.EvalDirect(kind, BitVector.alloc(a), BitVector.alloc(b)).Content;
                var result3 = BitVectorLogix.Service.EvalRef(kind, BitVector.alloc(a), BitVector.alloc(b)).Content;
                var result4 = VLogixOps.eval(kind, z.vbroadcast(n128,a), z.vbroadcast(n128,b)).ToScalar();
                var result5 = VLogixOps.eval(kind, z.vbroadcast(n256,a), z.vbroadcast(n256,b)).ToScalar();
                Claim.eq(result1, result2);
                Claim.eq(result2, result3);
                Claim.eq(result3, result4);
                Claim.eq(result4, result5);
            }
        }
     }
}