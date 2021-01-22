//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static BinaryBitLogicKind;

    public class t_bm_ops : LogixTest<t_bm_ops>
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
            bm_api_bench<ulong>(Xor);
            bm_delegate_bench<ulong>(Xor);
        }

         protected void bm_and_check<N,T>(BinaryBitLogicKind op = And)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample<RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = A[i] & B[i];
                    var actual = C[i];
                    Claim.eq(expect, actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        void bm_xor_check<N,T>(BinaryBitLogicKind op = Xor)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = A[i] ^ B[i];
                    var actual = C[i];
                    Claim.eq(expect, actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        void bm_imply_check<N,T>(BinaryBitLogicKind op = Impl)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.impl(A[i], B[i]);
                    var actual = C[i];
                    Claim.eq(expect, actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        void bm_notimply_check<N,T>(BinaryBitLogicKind op = NonImpl)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.nonimpl(A[i], B[i]);
                    var actual = C[i];
                    Claim.eq(expect,actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        void bm_xnor_check<N,T>(BinaryBitLogicKind op = Xnor)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.xnor(A[i], B[i]);
                    var actual = C[i];
                    Claim.eq(expect, actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

        protected void bm_not_check<N,T>(BinaryBitLogicKind op = LNot)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample < RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.not(A[i]);
                    var actual = C[i];
                    Claim.eq(expect, actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

         protected void bm_nand_check<N,T>(BinaryBitLogicKind op = Nand)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample< RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.nand(A[i], B[i]);
                    var actual = C[i];
                    Claim.eq(expect, actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }


         protected void bm_or_check<N,T>(BinaryBitLogicKind op = Or)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample< RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = A[i] | B[i];
                    var actual = C[i];
                    Claim.eq(expect, actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }

         protected void bm_nor_check<N,T>(BinaryBitLogicKind op = Nor)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = BitMatrix.alloc<T>();
            var n = z.nat32i<N>();

            for(var sample=0; sample<RepCount; sample++)
            {
                SquareBitLogix.eval(op, A, B, C);
                for(var i=0; i<n; i++)
                {
                    var expect = BitVector.nor(A[i], B[i]);
                    var actual = C[i];
                    Claim.eq(expect, actual);
                }

                Random.BitMatrix(ref A);
                Random.BitMatrix(ref B);
            }
        }


        void bm_api_bench<T>(BinaryBitLogicKind op, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"bm_{op.Format()}_{ApiIdentify.numeric<T>()}_api";

            var A = Random.BitMatrix<T>();
            var B = Random.BitMatrix<T>();
            var C = Random.BitMatrix<T>();
            var Z = BitMatrix.alloc<T>();
            var opcount = 0;

            clock.Start();

            for(var i=0; i<CycleCount; i++)
            {
                C = SquareBitLogix.eval(op, A, B, Z);
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
    }
}