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
    
    using static zfunc;
    using static LogicExpr;
    using static LogicExprSpec;


    public class t_ternary : UnitTest<t_ternary>
    {

        protected override int SampleSize => Pow2.T10;
        

        public void check_and_8u()        
            => check_binary_ops<BitVector8,byte>(OpKind.And);        

        public void check_and_16u()        
            => check_binary_ops<BitVector16,ushort>(OpKind.And);
        
        public void check_and_32u()        
            => check_binary_ops<BitVector32,uint>(OpKind.And);

        public void check_and_64u()        
            => check_binary_ops<BitVector64,ulong>(OpKind.And);

        public void check_nand_8u()        
            => check_binary_ops<BitVector8,byte>(OpKind.Nand);        

        public void check_nand_16u()        
            => check_binary_ops<BitVector16,ushort>(OpKind.Nand);
        
        public void check_nand_32u()        
            => check_binary_ops<BitVector32,uint>(OpKind.Nand);

        public void check_nand_64u()        
            => check_binary_ops<BitVector64,ulong>(OpKind.Nand);

        public void check_or_8u()        
            => check_binary_ops<BitVector8,byte>(OpKind.Or);        

        public void check_or_16u()        
            => check_binary_ops<BitVector16,ushort>(OpKind.Or);
        
        public void check_or_32u()        
            => check_binary_ops<BitVector32,uint>(OpKind.Or);

        public void check_or_64u()        
            => check_binary_ops<BitVector64,ulong>(OpKind.Or);

        public void check_nor_8u()        
            => check_binary_ops<BitVector8,byte>(OpKind.Nor);        

        public void check_nor_16u()        
            => check_binary_ops<BitVector16,ushort>(OpKind.Nor);
        
        public void check_nor_32u()        
            => check_binary_ops<BitVector32,uint>(OpKind.Nor);

        public void check_nor_64u()        
            => check_binary_ops<BitVector64,ulong>(OpKind.Nor);

        public void check_xor_8u()        
            => check_binary_ops<BitVector8,byte>(OpKind.XOr);        

        public void check_xor_16u()        
            => check_binary_ops<BitVector16,ushort>(OpKind.XOr);
        
        public void check_xor_32u()        
            => check_binary_ops<BitVector32,uint>(OpKind.XOr);

        public void check_xor_64u()        
            => check_binary_ops<BitVector64,ulong>(OpKind.XOr);

        public void check_xnor_8u()        
            => check_binary_ops<BitVector8,byte>(OpKind.XNor);        

        public void check_xnor_16u()        
            => check_binary_ops<BitVector16,ushort>(OpKind.XNor);
        
        public void check_xnor_32u()        
            => check_binary_ops<BitVector32,uint>(OpKind.XNor);

        public void check_xnor_64u()        
            => check_binary_ops<BitVector64,ulong>(OpKind.XNor);

        public void check_not_8u()        
            => check_unary_ops<BitVector64,ulong>(OpKind.Not);

        public void check_not_16u()        
            => check_unary_ops<BitVector64,ulong>(OpKind.Not);
        
        public void check_not_32u()        
            => check_unary_ops<BitVector64,ulong>(OpKind.Not);

        public void check_not_64u()        
            => check_unary_ops<BitVector64,ulong>(OpKind.Not);

        public void check_select_8u()
            => check_select<BitVector8,byte>();

        public void check_select_16u()        
            => check_select<BitVector16,ushort>();        

        public void check_select_32u()        
            => check_select<BitVector32,uint>();
        
        public void check_select_64u()
            => check_select<BitVector64,ulong>();

        public void check_f01_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X01);
        
        public void check_f01_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X01);
        
        public void check_f01_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X01);
        
        public void check_f01_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X01);

        public void check_f02_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X02);
        
        public void check_f02_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X02);
        
        public void check_f02_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X02);
        
        public void check_f02_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X02);

        public void check_f03_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X03);
        
        public void check_f03_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X03);
        
        public void check_f03_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X03);
        
        public void check_f03_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X03);

        public void check_f04_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X04);
        
        public void check_f04_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X04);
        
        public void check_f04_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X04);
        
        public void check_f04_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X04);

        public void check_f05_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X05);
        
        public void check_f05_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X05);
        
        public void check_f05_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X05);
        
        public void check_f05_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X05);

        public void check_f06_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X06);
        
        public void check_f06_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X06);
        
        public void check_f06_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X06);
        
        public void check_f06_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X06);

        public void check_f07_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X07);
        
        public void check_f07_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X07);
        
        public void check_f07_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X07);
        
        public void check_f07_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X07);

        public void check_f08_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X08);
        
        public void check_f08_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X08);
        
        public void check_f08_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X08);
        
        public void check_f08_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X08);

        public void check_f09_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X09);
        
        public void check_f09_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X09);
        
        public void check_f09_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X09);
        
        public void check_f09_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X09);

        public void check_f0a_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X0A);
        
        public void check_f0a_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X0A);
        
        public void check_f0a_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X0A);
        
        public void check_f0a_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X0A);

        public void check_f16_8u()
            => check_ternary_ops<BitVector8,byte>(ByteKind.X16);
        
        public void check_f16_16u()        
            => check_ternary_ops<BitVector16,ushort>(ByteKind.X16);
        
        public void check_f16_32u()        
            => check_ternary_ops<BitVector32,uint>(ByteKind.X16);
        
        public void check_f16_64u()        
            => check_ternary_ops<BitVector64,ulong>(ByteKind.X16);

        void check_unary_ops<V,T>(OpKind id)
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            var BL = BitLogic.unaryop(id);
            var SC = ScalarLogic.unaryop<T>(id);
            var BV = BvLogic.unaryop<V>(id);
            
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

        void check_binary_ops<V,T>(OpKind id)
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            var BL = BitLogic.binop(id);
            var SC = ScalarLogic.binop<T>(id);
            var BV = BvLogic.binop<V>(id);
            
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

        void check_ternary_ops<V,T>(ByteKind id)
            where V : unmanaged, IBitVector<V>
            where T : unmanaged
        {
            var BL = BitLogic.ternop(id);
            var SC = ScalarLogic.ternop<T>(id);
            var BV = BvLogic.ternop<V>(id);
            
            for(var sample = 0; sample< SampleSize; sample++)
            {
                var a = Random.BitVector<V>();
                var b = Random.BitVector<V>();
                var c = Random.BitVector<V>();

                var z0 = gbv.alloc<V>();
                for(var i=0; i< z0.Length; i++)
                    z0[i] = BL(a[i],b[i],c[i]);

                var z2 = BV(a,b,c);
                var z3 = SC(a.ToScalar<T>(), b.ToScalar<T>(), c.ToScalar<T>());
                                
                Claim.eq(z3, z0.ToScalar<T>());                                
                Claim.eq(z0, z2);
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
                    z0[i] = BitLogic.select(a[i],b[i],c[i]);
                
                var z2 = BvLogic.select(a,b,c);
                var z3 = ScalarLogic.select(a.ToScalar<T>(), b.ToScalar<T>(), c.ToScalar<T>());
                Claim.eq(z3, z0.ToScalar<T>());                                
                Claim.eq(z0, z2);
            }
        }


    }

}