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

        public void check_f01()
            => check_ternary_ops(TernaryLogicOpKind.X01);

        public void check_f02()
            => check_ternary_ops(TernaryLogicOpKind.X02);

        public void check_f03()
            => check_ternary_ops(TernaryLogicOpKind.X03);

        public void check_f04()
            => check_ternary_ops(TernaryLogicOpKind.X04);

        public void check_f05()
            => check_ternary_ops(TernaryLogicOpKind.X05);

        public void check_f06()
            => check_ternary_ops(TernaryLogicOpKind.X06);

        public void check_f07()
            => check_ternary_ops(TernaryLogicOpKind.X07);

        public void check_f08()
            => check_ternary_ops(TernaryLogicOpKind.X08);

        public void check_f09()
            => check_ternary_ops(TernaryLogicOpKind.X09);

        public void check_f0a()
            => check_ternary_ops(TernaryLogicOpKind.X0A);

        public void check_f0b()
            => check_ternary_ops(TernaryLogicOpKind.X0B);

        public void check_f0c()
            => check_ternary_ops(TernaryLogicOpKind.X0C);

        public void check_f0d()
            => check_ternary_ops(TernaryLogicOpKind.X0D);

        public void check_f0e()
            => check_ternary_ops(TernaryLogicOpKind.X0E);

        public void check_f0f()
            => check_ternary_ops(TernaryLogicOpKind.X0F);

        public void check_f10()
            => check_ternary_ops(TernaryLogicOpKind.X10);

        public void check_f11()
            => check_ternary_ops(TernaryLogicOpKind.X11);
           
        public void check_f12()
            => check_ternary_ops(TernaryLogicOpKind.X12);

        public void check_f13()
            => check_ternary_ops(TernaryLogicOpKind.X13);

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
                    Claim.eq(x[j], BitOps.select(a[j],b[j],c[j]));
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

        void check_ternary_ops(TernaryLogicOpKind op)
        {
            check_ternary_ops<byte>(op);
            check_ternary_ops<ushort>(op);
            check_ternary_ops<uint>(op);
            check_ternary_ops<ulong>(op);

        }

        void check_binary_ops(BinaryLogicOpKind op)
        {
            check_binary_ops<byte>(op);
            check_binary_ops<ushort>(op);
            check_binary_ops<uint>(op);
            check_binary_ops<ulong>(op);
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

        void check_binary_ops<T>(BinaryLogicOpKind id)
            where T : unmanaged
        {
            var BL = BitOpApi.lookup(id);
            var SC = ScalarOpApi.lookup<T>(id);
            
            for(var sample = 0; sample< SampleSize; sample++)
            {
                var sa = Random.Next<T>();
                var sb = Random.Next<T>();

                var z0 = bitvector.generic<T>();
                var va = bitvector.generic(sa);
                var vb = bitvector.generic(sb);

                for(var i=0; i< z0.Length; i++)
                    z0[i] = BL(va[i],vb[i]);

                var z3 = SC(sa,sb);
                                
                Claim.eq(z3, z0.Data);
            }
        }

        void check_ternary_ops<T>(TernaryLogicOpKind id)
            where T : unmanaged
        {
            var BL = BitOpApi.lookup(id);
            var SC = ScalarOpApi.lookup<T>(id);
            var V128 = Cpu128OpApi.lookup<T>(id);
            var V256 = Cpu256OpApi.lookup<T>(id);
            check_op_identity<T>(id);

            for(var sample = 0; sample< SampleSize; sample++)
            {
                var sa = Random.Next<T>();
                var sb = Random.Next<T>();
                var sc = Random.Next<T>();

                var z0 = bitvector.generic<T>();
                var va = bitvector.generic(sa);
                var vb = bitvector.generic(sb);
                var vc = bitvector.generic(sc);
                for(var i=0; i< z0.Length; i++)
                    z0[i] = BL(va[i],vb[i],vc[i]);

                var z3 = SC(sa, sb, sc);
                                
                Claim.eq(z3, z0.Data);                                

                var v1 = ginx.vbroadcast(n256,sa);
                var v2 = ginx.vbroadcast(n256,sb);
                var v3 = ginx.vbroadcast(n256,sc);
                var v4 = Vector256.GetElement(V256(v1,v2,v3), 0);
                Claim.eq(v4,z3);


                var u1 = ginx.vlo(v1);
                var u2 = ginx.vlo(v2);
                var u3 = ginx.vlo(v3);
                var u4 = Vector128.GetElement(V128(u1,u2,u3),0);
                Claim.eq(u4, z3);
            }

        }

        
        void check_select<V,T>()
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            for(var sample = 0; sample< SampleSize; sample++)
            {
                var a = Random.PrimalBitVector<V>();
                var b = Random.PrimalBitVector<V>();
                var c = Random.PrimalBitVector<V>();
                
                var z0 = gbv.alloc<V>();
                for(var i=0; i< z0.Length; i++)
                    z0[i] = bit.select(a[i],b[i],c[i]);
                
                var z3 = ScalarOps.select(a.ToScalar<T>(), b.ToScalar<T>(), c.ToScalar<T>());
                Claim.eq(z3, z0.ToScalar<T>());                                
            }
        }

    }
}