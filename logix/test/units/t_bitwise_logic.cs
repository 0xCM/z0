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

    /// <summary>
    /// Verifies the bit-level equivalence of the binary bitwise operators and the binary logical operators
    /// </summary>
    public class t_bitwise_logic : UnitTest<t_bitwise_logic>
    {

        public void bwl_and_check()
        {
            var op = BinaryBitwiseOpKind.And;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }
        
        public void bwl_nand_check()
        {
            var op = BinaryBitwiseOpKind.Nand;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }
        
        public void bwl_or_check()
        {
            var op = BinaryBitwiseOpKind.Or;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }
        
        public void bwl_nor_check()
        {
            var op = BinaryBitwiseOpKind.Nor;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_xor_check()
        {
            var op = BinaryBitwiseOpKind.XOr;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }
        
        public void bwl_xnor_check()
        {
            var op = BinaryBitwiseOpKind.Xnor;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_lnot_check()
        {
            var op = BinaryBitwiseOpKind.LeftNot;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }
        
        public void bwl_rnot_check()
        {
            var op = BinaryBitwiseOpKind.RightNot;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_imply_check()
        {
            var op = BinaryBitwiseOpKind.Implication;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }
        
        public void bwl_notimply_check()
        {
            var op = BinaryBitwiseOpKind.Nonimplication;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        public void bwl_cimply_check()
        {
            var op = BinaryBitwiseOpKind.ConverseImplication;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }
        
        public void bwl_cnotimply_check()
        {
            var op = BinaryBitwiseOpKind.ConverseNonimplication;
            bitwise_logic_check<byte>(op);
            bitwise_logic_check<ushort>(op);
            bitwise_logic_check<uint>(op);
            bitwise_logic_check<ulong>(op);
        }

        void bitwise_logic_check<T>(BinaryBitwiseOpKind kind)
            where T : unmanaged
        {
            for(var i=0; i< SampleSize; i++)   
            {   
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                var result1 = ScalarOpApi.eval(kind,a,b);    
                var result2 = BitVectorOpApi.eval(kind, BitVector.alloc(a), BitVector.alloc(b)).Data;
                var result3 = BitVectorOpApi.evalspec(kind, BitVector.alloc(a), BitVector.alloc(b)).Data;
                var result4 = CpuOpApi.eval(kind, ginx.vbroadcast(n128,a), ginx.vbroadcast(n128,b)).ToScalar();
                var result5 = CpuOpApi.eval(kind, ginx.vbroadcast(n256,a), ginx.vbroadcast(n256,b)).ToScalar();
                Claim.eq(result1, result2);
                Claim.eq(result2, result3);
                Claim.eq(result3, result4);
                Claim.eq(result4, result5);
            }
        }

    
    }

}