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
    using static TypedLogicSpec;
    using static BinaryBitwiseOpKind;

    public class t_bitmatrix_ops : UnitTest<t_bitmatrix_ops>
    {
    
        public void bm_not_check()
        {
            bm_not_check<N8,byte>();
            bm_not_check<N16,ushort>();
            bm_not_check<N32,uint>();
            bm_not_check<N64,ulong>();
        }

        public void bm_and_check()
        {
            bm_and_check<N8,byte>();
            bm_and_check<N16,ushort>();
            bm_and_check<N32,uint>();
            bm_and_check<N64,ulong>();
        }

        public void bm_nand_check()
        {
            bm_nand_check<N8,byte>();
            bm_nand_check<N16,ushort>();
            bm_nand_check<N32,uint>();
            bm_nand_check<N64,ulong>();
        }

        public void bm_or_check()
        {
            bm_or_check<N8,byte>();
            bm_or_check<N16,ushort>();
            bm_or_check<N32,uint>();
            bm_or_check<N64,ulong>();
        }

        public void bm_nor_check()
        {
            bm_nor_check<N8,byte>();
            bm_nor_check<N16,ushort>();
            bm_nor_check<N32,uint>();
            bm_nor_check<N64,ulong>();
        }

        public void bm_xor_check()
        {
            bm_xor_check<N8,byte>();
            bm_xor_check<N16,ushort>();
            bm_xor_check<N32,uint>();
            bm_xor_check<N64,ulong>();
        }

        public void bm_xnor_check()
        {
            bm_xnor_check<N8,byte>();
            bm_xnor_check<N16,ushort>();
            bm_xnor_check<N32,uint>();
            bm_xnor_check<N64,ulong>();
        }

        public void bm_imply_check()
        {
            bm_imply_check<N8,byte>();
            bm_imply_check<N16,ushort>();
            bm_imply_check<N32,uint>();
            bm_imply_check<N64,ulong>();
        }

        public void bm_notimply_check()
        {
            bm_notimply_check<N8,byte>();
            bm_notimply_check<N16,ushort>();
            bm_notimply_check<N32,uint>();
            bm_notimply_check<N64,ulong>();
        }

        public void bm_and_bench()
        {
            bm_and_bench<ulong>();
            bm_api_bench<ulong>(And);
            bm_delegate_bench<ulong>(And);
        }

        public void bm_xor_bench()
        {
            bm_xor_bench<ulong>();
            bm_api_bench<ulong>(XOr);
            bm_delegate_bench<ulong>(XOr);
        }

         void bm_and_check<N,T>(BinaryBitwiseOpKind op = And)
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

         void bm_nand_check<N,T>(BinaryBitwiseOpKind op = Nand)
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

         void bm_or_check<N,T>(BinaryBitwiseOpKind op = Or)
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

         void bm_nor_check<N,T>(BinaryBitwiseOpKind op = Nor)
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

        void bm_xor_check<N,T>(BinaryBitwiseOpKind op = XOr)
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

        void bm_xnor_check<N,T>(BinaryBitwiseOpKind op = Xnor)
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


        void bm_imply_check<N,T>(BinaryBitwiseOpKind op = Implication)
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
                    var expect = BitVector.imply(A[i], B[i]);
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }


        void bm_notimply_check<N,T>(BinaryBitwiseOpKind op = Nonimplication)
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
                    var expect = BitVector.notimply(A[i], B[i]);
                    var actual = C[i];
                    Claim.yea<T>(expect == actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        void bm_not_check<N,T>(BinaryBitwiseOpKind op = LeftNot)
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



        void bm_delegate_bench<T>(BinaryBitwiseOpKind opkind, SystemCounter clock = default)
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

        void bm_api_bench<T>(BinaryBitwiseOpKind op, SystemCounter clock = default)
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

        void bm_and_bench<T>(SystemCounter clock = default)
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

        void bm_xor_bench<T>(SystemCounter clock = default)
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

    }
}
