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


    public class t_ternary_logic : UnitTest<t_ternary_logic>
    {

        protected override int SampleSize => Pow2.T08;
        
        public void check_op_identities()
        {                         
             ScalarOpApi.TernaryBitwiseKinds.Iterate(op => check_op_identity<byte>(op));
             ScalarOpApi.TernaryBitwiseKinds.Iterate(op => check_op_identity<ushort>(op));
             ScalarOpApi.TernaryBitwiseKinds.Iterate(op => check_op_identity<uint>(op));
             ScalarOpApi.TernaryBitwiseKinds.Iterate(op => check_op_identity<ulong>(op));
        }

        public void check_and() 
            => check_binary_ops(BinaryBitwiseOpKind.And);

        public void check_nand()        
            => check_binary_ops(BinaryBitwiseOpKind.Nand);

        public void check_or()        
            => check_binary_ops(BinaryBitwiseOpKind.Or);

        public void check_nor()        
            => check_binary_ops(BinaryBitwiseOpKind.Nor);

        public void check_xor()        
            => check_binary_ops(BinaryBitwiseOpKind.XOr);

        public void check_xnor()        
            => check_binary_ops(BinaryBitwiseOpKind.Xnor);

        public void check_select()
        {
            check_select<byte>();
            check_select<ushort>();
            check_select<uint>();
            check_select<ulong>();
            check_select<byte>(n128);
            check_select<ushort>(n128);
            check_select<uint>(n128);
            check_select<ulong>(n128);
            check_select<byte>(n256);
            check_select<ushort>(n256);
            check_select<uint>(n256);
            check_select<ulong>(n256);

        }


        void check_select<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var width = bitsize<T>();
                var a = Random.BitVector<T>();
                var b = Random.BitVector<T>();
                var c = Random.BitVector<T>();
                BitVector<T> x = ScalarOps.select(a.Data, b.Data, c.Data);
                for(var j=0; j<x.Length; j++)
                    Claim.eq(x[j], LogicOps.select(a[j],b[j],c[j]));
            }

        }

        void check_select<T>(N128 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.CpuVector<T>(n);
                var b = Random.CpuVector<T>(n);
                var c = Random.CpuVector<T>(n);
                var x = CpuOps.select(a,b,c);

                var sa = a.ToSpan();
                var sb = b.ToSpan();
                var sc = c.ToSpan();
                var sx = x.ToSpan();

                for(var j=0; j< sx.Length; j++)
                    Claim.eq(sx[j], ScalarOps.select(sa[j], sb[j], sc[j]));
            }

        }


        void check_select<T>(N256 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.CpuVector<T>(n);
                var b = Random.CpuVector<T>(n);
                var c = Random.CpuVector<T>(n);
                var x = CpuOps.select(a,b,c);

                var sa = a.ToSpan();
                var sb = b.ToSpan();
                var sc = c.ToSpan();
                var sx = x.ToSpan();

                for(var j=0; j< sx.Length; j++)
                    Claim.eq(sx[j], ScalarOps.select(sa[j], sb[j], sc[j]));
            }

        }


        void check_binary_ops(BinaryBitwiseOpKind op)
        {
            check_binary_op<byte>(op);
            check_binary_op<ushort>(op);
            check_binary_op<uint>(op);
            check_binary_op<ulong>(op);
        }

        void check_op_identity<T>(TernaryOpKind id)
            where T: unmanaged
        {
            var a = convert<T>(0b1111_0000);
            var b = convert<T>(0b1100_1100);
            var c = convert<T>(0b1010_1010);
            var mask = convert<T>(0xFF);
            var f = ScalarOpApi.lookup<T>(id);
            var actual = convert<T,byte>(gmath.and(f(a,b,c), mask));
            var expect = (byte)id;
            Claim.eq(expect.FormatHex(), actual.FormatHex());
        }

        void check_binary_op<T>(BinaryBitwiseOpKind id)
            where T : unmanaged
        {
            var BL = LogicOpApi.lookup((BinaryLogicOpKind)id);
            var SC = ScalarOpApi.lookup<T>(id);
            
            for(var sample = 0; sample< SampleSize; sample++)
            {
                var sa = Random.Next<T>();
                var sb = Random.Next<T>();

                var z0 = BitVector.generic<T>();
                var va = BitVector.generic(sa);
                var vb = BitVector.generic(sb);

                for(var i=0; i< z0.Length; i++)
                    z0[i] = BL(va[i],vb[i]);

                var z3 = SC(sa,sb);
                                
                Claim.eq(z3, z0.Data);
            }
        }


    }
}