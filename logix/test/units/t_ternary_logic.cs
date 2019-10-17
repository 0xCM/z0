//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
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
            
             ScalarLogic.ternops.Iterate(op => check_op_identity<byte>(op));
             ScalarLogic.ternops.Iterate(op => check_op_identity<ushort>(op));
             ScalarLogic.ternops.Iterate(op => check_op_identity<uint>(op));
             ScalarLogic.ternops.Iterate(op => check_op_identity<ulong>(op));
        }

        void ternary_table()
        {
            BitVector8 id = (byte)TernaryLogicOpKind.X09;
            var tt = table(TernaryLogicOpKind.X09);
            Trace($"Table {id.Format()}");
            Trace(tt.Format());

        }

        BitMatrix<N8,N4, byte> table(TernaryLogicOpKind op)
            => BooleanLogic.table(op);


        void truth_tables_all()
        {
            for(var i=0; i< 16; i++)
            {
                BitVector4 result = (byte)i;
                var tt = BitMatrix.Alloc<N4,N3,byte>();
                tt[0] = BitVector.Define<N3,byte>(Bits.pack3(result[0], Bit.Off, Bit.Off));
                tt[1] = BitVector.Define<N3,byte>(Bits.pack3(result[1], Bit.Off, Bit.On));
                tt[2] = BitVector.Define<N3,byte>(Bits.pack3(result[2], Bit.On, Bit.Off));
                tt[3] = BitVector.Define<N3,byte>(Bits.pack3(result[3], Bit.On, Bit.On));
                Trace($"Table {result.Format()}");
                Trace(tt.Format());

            }
        }

        void truth_tables()
        {
            BitMatrix<N4,N3,byte> table = default;
            BitVector<N4,byte> result = default;
            var op = BinaryLogicOpKind.And;
            table = BooleanLogic.table(op);
            result = table.GetCol(2);
            Trace($"{op.ToString()} {result.Format()}");
            Trace(table.Format());

            op = BinaryLogicOpKind.Nand;
            table = BooleanLogic.table(op);
            result = table.GetCol(2);

            Trace($"{op.ToString()} {result.Format()}");
            Trace(table.Format());

            op = BinaryLogicOpKind.Or;
            table = BooleanLogic.table(op);
            result = table.GetCol(2);

            Trace($"{op.ToString()} {result.Format()}");
            Trace(table.Format());

            op = BinaryLogicOpKind.Nor;
            table = BooleanLogic.table(op);
            result = table.GetCol(2);

            Trace($"{op.ToString()} {result.Format()}");
            Trace(table.Format());


            op = BinaryLogicOpKind.XOr;
            table = BooleanLogic.table(op);
            result = table.GetCol(2);

            Trace($"{op.ToString()} {result.Format()}");
            Trace(table.Format());

            op = BinaryLogicOpKind.Xnor;
            table = BooleanLogic.table(op);
            result = table.GetCol(2);

            Trace($"{op.ToString()} {result.Format()}");
            Trace(table.Format());

            op = BinaryLogicOpKind.AndNot;
            table = BooleanLogic.table(op);
            result = table.GetCol(2);

            Trace($"{op.ToString()} {result.Format()}");
            Trace(table.Format());

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


        public void check_not()  
        {      
            check_unary_ops<BitVector8,byte>(UnaryLogicOpKind.Not);
            check_unary_ops<BitVector16,ushort>(UnaryLogicOpKind.Not);
            check_unary_ops<BitVector32,uint>(UnaryLogicOpKind.Not);
            check_unary_ops<BitVector64,ulong>(UnaryLogicOpKind.Not);
        }


        public void check_select()
        {
            check_select<BitVector8,byte>();
            check_select<BitVector16,ushort>();        
            check_select<BitVector32,uint>();
            check_select<BitVector64,ulong>();
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

        void check_ternary_ops(TernaryLogicOpKind op)
        {
            check_ternary_ops<BitVector8,byte>(op);
            check_ternary_ops<BitVector16,ushort>(op);
            check_ternary_ops<BitVector32,uint>(op);
            check_ternary_ops<BitVector64,ulong>(op);
        }

        void check_binary_ops(BinaryLogicOpKind op)
        {
            check_binary_ops<BitVector8,byte>(op);
            check_binary_ops<BitVector16,ushort>(op);
            check_binary_ops<BitVector32,uint>(op);
            check_binary_ops<BitVector64,ulong>(op);
        }

        void check_op_identity<T>(TernaryLogicOpKind id)
            where T: unmanaged
        {
            var a = convert<T>(0b1111_0000);
            var b = convert<T>(0b1100_1100);
            var c = convert<T>(0b1010_1010);
            var mask = convert<T>(0xFF);
            var f = ScalarLogic.ternop<T>(id);
            var actual = convert<T,byte>(gmath.and(f(a,b,c), mask));
            var expect = (byte)id;
            Claim.eq(expect.FormatHex(), actual.FormatHex());
        }

        void check_unary_ops<V,T>(UnaryLogicOpKind id)
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            var BL = BooleanLogic.unaryop(id);
            var SC = ScalarLogic.unaryop<T>(id);
            var BV = VectorLogic.unaryop<V>(id);
            
            for(var sample = 0; sample< SampleSize; sample++)
            {
                var a = Random.BitVector<V>();

                var z0 = gbv.alloc<V>();
                for(var i=0; i< z0.Length; i++)
                    z0[i] = BL(a[i]);

                var z2 = BV(a);
                var z3 = SC(a.ToScalar<T>());
                                
                Claim.eq(z3, z0.ToScalar<T>());                                
                Claim.eq(z0, z2);
            }
        }

        void check_binary_ops<V,T>(BinaryLogicOpKind id)
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            var BL = BooleanLogic.binop(id);
            var SC = ScalarLogic.binop<T>(id);
            var BV = VectorLogic.binop<V>(id);
            
            for(var sample = 0; sample< SampleSize; sample++)
            {
                var a = Random.BitVector<V>();
                var b = Random.BitVector<V>();

                var z0 = gbv.alloc<V>();
                for(var i=0; i< z0.Length; i++)
                    z0[i] = BL(a[i],b[i]);

                var z2 = BV(a,b);
                var z3 = SC(a.ToScalar<T>(), b.ToScalar<T>());
                                
                Claim.eq(z3, z0.ToScalar<T>());                                
                Claim.eq(z0, z2);
            }
        }

        void check_ternary_ops<V,T>(TernaryLogicOpKind id)
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            var BL = BooleanLogic.ternop(id);
            var SC = ScalarLogic.ternop<T>(id);
            var BV = VectorLogic.ternop<V>(id);
            var V128 = CpuLogic128.ternop<T>(id);
            var V256 = CpuLogic256.ternop<T>(id);
            check_op_identity<T>(id);

            for(var sample = 0; sample< SampleSize; sample++)
            {
                var a = Random.BitVector<V>();
                var sa = a.ToScalar<T>();
                var b = Random.BitVector<V>();
                var sb = b.ToScalar<T>();
                var c = Random.BitVector<V>();
                var sc = c.ToScalar<T>();

                var z0 = gbv.alloc<V>();
                for(var i=0; i< z0.Length; i++)
                    z0[i] = BL(a[i],b[i],c[i]);


                var z2 = BV(a,b,c);
                var z3 = SC(sa, sb, sc);
                                
                Claim.eq(z3, z0.ToScalar<T>());                                
                Claim.eq(z0, z2);

                var v1 = ginx.vbroadcast256(sa);
                var v2 = ginx.vbroadcast256(sb);
                var v3 = ginx.vbroadcast256(sc);
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
                var a = Random.BitVector<V>();
                var b = Random.BitVector<V>();
                var c = Random.BitVector<V>();
                
                var z0 = gbv.alloc<V>();
                for(var i=0; i< z0.Length; i++)
                    z0[i] = bit.select(a[i],b[i],c[i]);
                
                var z2 = VectorLogic.select(a,b,c);
                var z3 = ScalarLogic.select(a.ToScalar<T>(), b.ToScalar<T>(), c.ToScalar<T>());
                Claim.eq(z3, z0.ToScalar<T>());                                
                Claim.eq(z0, z2);
            }
        }

    }
}