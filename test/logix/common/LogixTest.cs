//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Memories;

    using static BitLogicSpec;
    using static LogicEngine;
    using static BinaryLogicKind;

    using BL = BinaryLogicKind;

    public abstract class LogixTest<X> : UnitTest<X, CheckVectorBits, ICheckVectorBits>
        where X : LogixTest<X>
    {
        BitLogix bitlogix => BitLogix.Service;

        protected void logic_op_check(BL kind, Func<bit,bit,bit> rule)
        {
            var lhs = Random.BitStream32().Take(RepCount).ToArray();
            var rhs = Random.BitStream32().Take(RepCount).ToArray();
            for(var i=0; i<RepCount; i++)
            {
                var a = lhs[i];
                var b = rhs[i];
                var expect = rule(a,b);
                var actual = bitlogix.Evaluate(kind, a,b);
                Claim.Eq(expect, actual);
            }
        }

        protected void logic_expr_check(BL kind, Func<bit,bit,bit> rule)
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
                Claim.Eq(expect,e1);
            }
        }

        protected void logic_op_bench(bool lookup, SystemCounter clock = default)
        {
            var opname = $"ops/logical/lookup[{lookup}]";

            var lhsSamples = Random.BitStream32().Take(RepCount).ToArray();
            var rhsSamples = Random.BitStream32().Take(RepCount).ToArray();
            var result = bit.Off;
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

         protected void bm_and_check<N,T>(BinaryLogicKind op = And)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample< RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = A[i] & B[i];
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

         protected void bm_nand_check<N,T>(BinaryLogicKind op = Nand)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample< RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.nand(A[i], B[i]);
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

         protected void bm_or_check<N,T>(BinaryLogicKind op = Or)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample< RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = A[i] | B[i];
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

         protected void bm_nor_check<N,T>(BinaryLogicKind op = Nor)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample< RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.nor(A[i], B[i]);
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        protected void bm_xor_check<N,T>(BinaryLogicKind op = Xor)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = A[i] ^ B[i];
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        protected void bm_xnor_check<N,T>(BinaryLogicKind op = Xnor)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.xnor(A[i], B[i]);
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }


        protected void bm_imply_check<N,T>(BinaryLogicKind op = Impl)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.impl(A[i], B[i]);
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        protected void bm_notimply_check<N,T>(BinaryLogicKind op = NonImpl)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.nonimpl(A[i], B[i]);
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        protected void bm_not_check<N,T>(BinaryLogicKind op = LNot)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = nati<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.not(A[i]);
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        protected void bm_delegate_bench<T>(BinaryLogicKind opkind, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_{opkind.Format()}_{ApiIdentity.numeric<T>()}_delegate";
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

        protected void bm_api_bench<T>(BinaryLogicKind op, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_{op.Format()}_{ApiIdentity.numeric<T>()}_api";

            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {
                SquareBitLogix.eval(op, A, B, Z);
                opcount++;
                for(var sample=0; sample< RepCount; sample++)
                {
                    SquareBitLogix.eval(op, Z, A, Z);
                    SquareBitLogix.eval(op, B, Z, Z);
                    opcount +=2;
                }
            }

            clock.Stop();

            ReportBenchmark(opname, opcount, clock);
        }

        protected void bm_and_bench<T>(SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_and_{ApiIdentity.numeric<T>()}";

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
            var opname = $"bm_xor_{ApiIdentity.numeric<T>()}";

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

       protected void bitwise_logic_check<T>(BinaryLogicKind kind)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                var result1 = NumericLogixHost.eval(kind,a,b);
                var result2 = BitVectorLogix.Service.EvalDirect(kind, BitVector.alloc(a), BitVector.alloc(b)).Scalar;
                var result3 = BitVectorLogix.Service.EvalRef(kind, BitVector.alloc(a), BitVector.alloc(b)).Scalar;
                var result4 = VLogixOps.eval(kind, Vectors.vbroadcast(n128,a), Vectors.vbroadcast(n128,b)).ToScalar();
                var result5 = VLogixOps.eval(kind, Vectors.vbroadcast(n256,a), Vectors.vbroadcast(n256,b)).ToScalar();
                Claim.Eq(result1, result2);
                Claim.Eq(result2, result3);
                Claim.Eq(result3, result4);
                Claim.Eq(result4, result5);
            }
        }
     }
}