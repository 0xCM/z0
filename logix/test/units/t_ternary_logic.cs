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
             ScalarOpApi.TernaryKinds.Iterate(op => check_op_identity<byte>(op));
             ScalarOpApi.TernaryKinds.Iterate(op => check_op_identity<ushort>(op));
             ScalarOpApi.TernaryKinds.Iterate(op => check_op_identity<uint>(op));
             ScalarOpApi.TernaryKinds.Iterate(op => check_op_identity<ulong>(op));
        }

        public void check_and() 
            => check_binary_ops(BinaryLogicOpKind.And);

        public void check_nand()        
            => check_binary_ops(BinaryLogicOpKind.Nand);

        public void check_or()        
            => check_binary_ops(BinaryLogicOpKind.Or);

        public void check_nor()        
            => check_binary_ops(BinaryLogicOpKind.Nor);

        public void check_xor()        
            => check_binary_ops(BinaryLogicOpKind.XOr);

        public void check_xnor()        
            => check_binary_ops(BinaryLogicOpKind.Xnor);

        public void check_select()
        {
            check_select<byte>();
            check_select<ushort>();
            check_select<uint>();
            check_select<ulong>();
            check_select_128<byte>();
            check_select_128<ushort>();
            check_select_128<uint>();
            check_select_128<ulong>();
            check_select_256<byte>();
            check_select_256<ushort>();
            check_select_256<uint>();
            check_select_256<ulong>();

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

        void check_select_128<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.CpuVector128<T>();
                var b = Random.CpuVector128<T>();
                var c = Random.CpuVector128<T>();
                var x = Cpu128Ops.select(a,b,c);

                var sa = a.ToSpan();
                var sb = b.ToSpan();
                var sc = c.ToSpan();
                var sx = x.ToSpan();

                for(var j=0; j< sx.Length; j++)
                    Claim.eq(sx[j], ScalarOps.select(sa[j], sb[j], sc[j]));
            }

        }

        void check_select_256<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var a = Random.CpuVector256<T>();
                var b = Random.CpuVector256<T>();
                var c = Random.CpuVector256<T>();
                var x = Cpu256Ops.select(a,b,c);

                var sa = a.ToSpan();
                var sb = b.ToSpan();
                var sc = c.ToSpan();
                var sx = x.ToSpan();

                for(var j=0; j< sx.Length; j++)
                    Claim.eq(sx[j], ScalarOps.select(sa[j], sb[j], sc[j]));
            }

        }


        void check_binary_ops(BinaryLogicOpKind op)
        {
            check_binary_op<byte>(op);
            check_binary_op<ushort>(op);
            check_binary_op<uint>(op);
            check_binary_op<ulong>(op);
        }

        void check_op_identity<T>(TernaryLogicOpKind id)
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

        void check_binary_op<T>(BinaryLogicOpKind id)
            where T : unmanaged
        {
            var BL = LogicOpApi.lookup(id);
            var SC = ScalarOpApi.lookup<T>(id);
            
            for(var sample = 0; sample< SampleSize; sample++)
            {
                var sa = Random.Next<T>();
                var sb = Random.Next<T>();

                var z0 = BitVector.Generic<T>();
                var va = BitVector.Generic(sa);
                var vb = BitVector.Generic(sb);

                for(var i=0; i< z0.Length; i++)
                    z0[i] = BL(va[i],vb[i]);

                var z3 = SC(sa,sb);
                                
                Claim.eq(z3, z0.Data);
            }
        }

        void check_select<V,T>()
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            for(var sample = 0; sample< SampleSize; sample++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                var c = Random.Next<T>();
                
                var z0 = BitVector.Generic<T>();
                var va = BitVector.Generic(a);
                var vb = BitVector.Generic(b);
                var vc = BitVector.Generic(b);

                for(var i=0; i< z0.Length; i++)
                    z0[i] = bit.select(va[i],vb[i],vc[i]);
                
                var z3 = ScalarOps.select(a, b, c);
                Claim.eq(z3, z0.Data);                                
            }
        }

    }
}