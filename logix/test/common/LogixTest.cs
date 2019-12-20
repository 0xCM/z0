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
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static ScalarOpApi;
    using static LogicOpApi;
    
    using static BitLogicSpec;
    using static LogicEngine;
    using static BinaryBitwiseOpKind;
    
    using BL = BinaryLogicOpKind;

    public abstract class LogixTest<X> : UnitTest<X>
        where X : LogixTest<X>
    {
        protected void logic_op_check(BL kind, Func<bit,bit,bit> rule)
        {
            var lhsBits = Random.TakeBits(SampleSize);
            var rhsBits = Random.TakeBits(SampleSize);
            for(var i=0; i<SampleSize; i++)
            {
                var a = lhsBits[i];
                var b = rhsBits[i];
                var expect = rule(a,b);
                var actual = LogicOpApi.eval(kind, a,b);
                Claim.eq(expect, actual);
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
                Claim.eq(expect,e1);
            }
        }

        protected void logic_op_bench(bool lookup, SystemCounter clock = default)
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

         protected void bm_and_check<N,T>(BinaryBitwiseOpKind op = And)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample< SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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

         protected void bm_nand_check<N,T>(BinaryBitwiseOpKind op = Nand)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample< SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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

         protected void bm_or_check<N,T>(BinaryBitwiseOpKind op = Or)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample< SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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

         protected void bm_nor_check<N,T>(BinaryBitwiseOpKind op = Nor)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample< SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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

        protected void bm_xor_check<N,T>(BinaryBitwiseOpKind op = XOr)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample < SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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

        protected void bm_xnor_check<N,T>(BinaryBitwiseOpKind op = Xnor)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample < SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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


        protected void bm_imply_check<N,T>(BinaryBitwiseOpKind op = Implication)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample < SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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

        protected void bm_notimply_check<N,T>(BinaryBitwiseOpKind op = Nonimplication)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample < SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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

        protected void bm_not_check<N,T>(BinaryBitwiseOpKind op = LeftNot)
            where T : unmanaged
            where N : unmanaged, ITypeNat

        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = natval<N>();

            for(var sample=0; sample < SampleSize; sample++)
            {
                BitMatrixOpApi.eval(op, A, B, ref C);
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

        protected void bm_delegate_bench<T>(BinaryBitwiseOpKind opkind, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_{opkind.Format()}_{moniker<T>()}_delegate";

            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;
            var Op = BitMatrixOpApi.lookup<T>(opkind);

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {            
                Op(A, B, ref Z);
                opcount++;
                for(var sample=0; sample< SampleSize; sample++)
                {
                    Op(Z, A, ref Z);                    
                    Op(B, Z, ref Z); 
                    opcount +=2;                   
                }
            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }

        protected void bm_api_bench<T>(BinaryBitwiseOpKind op, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_{op.Format()}_{moniker<T>()}_api";

            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {            
                BitMatrixOpApi.eval(op, A, B, ref Z);
                opcount++;
                for(var sample=0; sample< SampleSize; sample++)
                {
                    BitMatrixOpApi.eval(op, Z, A, ref Z);                    
                    BitMatrixOpApi.eval(op, B, Z, ref Z); 
                    opcount +=2;                   
                }
            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }

        protected void bm_and_bench<T>(SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_and_{moniker<T>()}";

            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {            
                BitMatrixOps.and(A, B, ref Z);
                opcount++;
                for(var sample=0; sample< SampleSize; sample++)
                {
                    BitMatrixOps.and(Z, A, ref Z);                    
                    BitMatrixOps.and(B, Z, ref Z); 
                    opcount +=2;                   
                }
            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }

        protected void bm_xor_bench<T>(SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_xor_{moniker<T>()}";

            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {            
                BitMatrixOps.xor(A, B, ref Z);
                opcount++;
                for(var sample=0; sample< SampleSize; sample++)
                {
                    BitMatrixOps.xor(Z, A, ref Z);                    
                    BitMatrixOps.xor(B, Z, ref Z); 
                    opcount +=2;                   
                }
            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }

       protected void bitwise_logic_check<T>(BinaryBitwiseOpKind kind)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)   
            {   
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                var result1 = ScalarOpApi.eval(kind,a,b);    
                var result2 = BitVectorOpApi.eval(kind, BitVector.alloc(a), BitVector.alloc(b)).Scalar;
                var result3 = BitVectorOpApi.evalspec(kind, BitVector.alloc(a), BitVector.alloc(b)).Scalar;
                var result4 = CpuOpApi.eval(kind, CpuVector.broadcast(n128,a), CpuVector.broadcast(n128,b)).ToScalar();
                var result5 = CpuOpApi.eval(kind, CpuVector.broadcast(n256,a), CpuVector.broadcast(n256,b)).ToScalar();
                Claim.eq(result1, result2);
                Claim.eq(result2, result3);
                Claim.eq(result3, result4);
                Claim.eq(result4, result5);
            }
        }

     }
}

