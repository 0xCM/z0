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

    public class t_typed_logic : UnitTest<t_typed_logic>
    {
        
        public void check_implies()
        {
            var dst = BitVector4.Alloc();
            dst[0] = (byte)(ScalarOps.implies((byte)0,(byte)0) & 1) == 1;
            dst[1] = (byte)(ScalarOps.implies((byte)1,(byte)0) & 1) == 1;
            dst[2] = (byte)(ScalarOps.implies((byte)0,(byte)1) & 1) == 1;
            dst[3] = (byte)(ScalarOps.implies((byte)1,(byte)1) & 1) == 1;
            var sig = TruthTables.Signature(BinaryLogicOpKind.Implies);
            Claim.eq(sig,dst);
        }

        public void check_not()  
        {      
            check_op<byte>(UnaryBitwiseOpKind.Not);
            check_op<ushort>(UnaryBitwiseOpKind.Not);
            check_op<uint>(UnaryBitwiseOpKind.Not);
            check_op<ulong>(UnaryBitwiseOpKind.Not);
        }


        // ~ and
        public void check_and_8u()
            => check_op<byte>(BinaryBitwiseOpKind.And);

        public void check_and_16u()
            => check_op<ushort>(BinaryBitwiseOpKind.And);
        public void check_and_32u()
            => check_op<uint>(BinaryBitwiseOpKind.And);
        public void check_and_64u()
            => check_op<ulong>(BinaryBitwiseOpKind.And);

        public void check_and_128x8u()
            => check_op_128<byte>(BinaryBitwiseOpKind.And);

        public void check_and_128x16u()
            => check_op_128<ushort>(BinaryBitwiseOpKind.And);

        public void check_and_128x32u()
            => check_op_128<uint>(BinaryBitwiseOpKind.And);

        public void check_and_128x64u()
            => check_op_128<ulong>(BinaryBitwiseOpKind.And);

        public void check_and_256x8u()
            => check_op_256<byte>(BinaryBitwiseOpKind.And);

        public void check_and_256x16u()
            => check_op_256<ushort>(BinaryBitwiseOpKind.And);

        public void check_and_256x32u()
            => check_op_256<uint>(BinaryBitwiseOpKind.And);

        public void check_and_256x64u()
            => check_op_256<ulong>(BinaryBitwiseOpKind.And);

        // ~ nand
        public void check_nand_8u()
            => check_op<byte>(BinaryBitwiseOpKind.Nand);

        public void check_nand_16u()
            => check_op<ushort>(BinaryBitwiseOpKind.Nand);
        
        public void check_nand_32u()
            => check_op<uint>(BinaryBitwiseOpKind.Nand);
        
        public void check_nand_64u()
            => check_op<ulong>(BinaryBitwiseOpKind.Nand);

        public void check_nand_128x8u()
            => check_op_128<byte>(BinaryBitwiseOpKind.Nand);

        public void check_nand_128x16u()
            => check_op_128<ushort>(BinaryBitwiseOpKind.Nand);

        public void check_nand_128x32u()
            => check_op_128<uint>(BinaryBitwiseOpKind.Nand);

        public void check_nand_128x64u()
            => check_op_128<ulong>(BinaryBitwiseOpKind.Nand);

        public void check_nand_256x8u()
            => check_op_256<byte>(BinaryBitwiseOpKind.Nand);

        public void check_nand_256x16u()
            => check_op_256<ushort>(BinaryBitwiseOpKind.Nand);

        public void check_nand_256x32u()
            => check_op_256<uint>(BinaryBitwiseOpKind.Nand);

        public void check_nand_256x64u()
            => check_op_256<ulong>(BinaryBitwiseOpKind.Nand);
        
        // ~ or
        public void check_or_8u()
            => check_op<byte>(BinaryBitwiseOpKind.Or);

        public void check_or_128x8u()
            => check_op_128<byte>(BinaryBitwiseOpKind.Or);

        public void check_or_256x8u()
            => check_op_256<byte>(BinaryBitwiseOpKind.Or);

        public void check_or_16u()
            => check_op<ushort>(BinaryBitwiseOpKind.Or);

        public void check_or_128x16u()
            => check_op_128<ushort>(BinaryBitwiseOpKind.Or);

        public void check_or_256x16u()
            => check_op_256<ushort>(BinaryBitwiseOpKind.Or);

        public void check_or_32u()
            => check_op<uint>(BinaryBitwiseOpKind.Or);

        public void check_or_128x32u()
            => check_op_128<uint>(BinaryBitwiseOpKind.Or);

        public void check_or_256x32u()
            => check_op_256<uint>(BinaryBitwiseOpKind.Or);

        public void check_or_64u()
            => check_op<ulong>(BinaryBitwiseOpKind.Or);

        public void check_or_128x64u()
            => check_op_128<ulong>(BinaryBitwiseOpKind.Or);

        public void check_or_256x64u()
            => check_op_256<ulong>(BinaryBitwiseOpKind.Or);

        // ~ nor
        public void check_nor_8u()
            => check_op<byte>(BinaryBitwiseOpKind.Nor);

        public void check_nor_128x8u()
            => check_op_128<byte>(BinaryBitwiseOpKind.Nor);

        public void check_nor_256x8u()
            => check_op_256<byte>(BinaryBitwiseOpKind.Nor);

        public void check_nor_16u()
            => check_op<ushort>(BinaryBitwiseOpKind.Nor);

        public void check_nor_128x16u()
            => check_op_128<ushort>(BinaryBitwiseOpKind.Nor);

        public void check_nor_256x16u()
            => check_op_256<ushort>(BinaryBitwiseOpKind.Nor);

        public void check_nor_32u()
            => check_op<uint>(BinaryBitwiseOpKind.Nor);

        public void check_nor_128x32u()
            => check_op_128<uint>(BinaryBitwiseOpKind.Nor);

        public void check_nor_256x32u()
            => check_op_256<uint>(BinaryBitwiseOpKind.Nor);

        public void check_nor_64u()
            => check_op<ulong>(BinaryBitwiseOpKind.Nor);

        public void check_nor_128x64u()
            => check_op_128<ulong>(BinaryBitwiseOpKind.Nor);

        public void check_nor_256x64u()
            => check_op_256<ulong>(BinaryBitwiseOpKind.Nor);

        // ~ xor

        public void check_xor_8u()
            => check_op<byte>(BinaryBitwiseOpKind.XOr);

        public void check_xor_128x8u()
            => check_op_128<byte>(BinaryBitwiseOpKind.XOr);

        public void check_xor_256x8u()
            => check_op_256<byte>(BinaryBitwiseOpKind.XOr);

        public void check_xor_16u()
            => check_op<ushort>(BinaryBitwiseOpKind.XOr);

        public void check_xor_128x16u()
            => check_op_128<ushort>(BinaryBitwiseOpKind.XOr);

        public void check_xor_256x16u()
            => check_op_256<ushort>(BinaryBitwiseOpKind.XOr);

        public void check_xor_32u()
            => check_op<uint>(BinaryBitwiseOpKind.XOr);

        public void check_xor_128x32u()
            => check_op_128<uint>(BinaryBitwiseOpKind.XOr);

        public void check_xor_256x32u()
            => check_op_256<uint>(BinaryBitwiseOpKind.XOr);

        public void check_xor_64u()
            => check_op<ulong>(BinaryBitwiseOpKind.XOr);

        public void check_xor_128x64u()
            => check_op_128<ulong>(BinaryBitwiseOpKind.XOr);

        public void check_xor_256x64u()
            => check_op_256<ulong>(BinaryBitwiseOpKind.XOr);

        // ~ xnor

        public void check_xnor_8u()
            => check_op<byte>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_128x8u()
            => check_op_128<byte>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_256x8u()
            => check_op_256<byte>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_16u()
            => check_op<ushort>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_128x16u()
            => check_op_128<ushort>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_256x16u()
            => check_op_256<ushort>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_32u()
            => check_op<uint>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_128x32u()
            => check_op_128<uint>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_256x32u()
            => check_op_256<uint>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_64u()
            => check_op<ulong>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_128x64u()
            => check_op_128<ulong>(BinaryBitwiseOpKind.Xnor);

        public void check_xnor_256x64u()
            => check_op_256<ulong>(BinaryBitwiseOpKind.Xnor);

        // ~ sll

        public void check_sll_8u()
            => check_op<byte>(ShiftOpKind.Sll);

        public void check_sll_128x8u()
            => check_op_128<byte>(ShiftOpKind.Sll);

        public void check_sll_256x8u()
            => check_op_256<byte>(ShiftOpKind.Sll);

        public void check_sll_32u()
            => check_op<uint>(ShiftOpKind.Sll);

        public void check_sll_128x32u()
            => check_op_128<uint>(ShiftOpKind.Sll);

        public void check_sll_256x32u()
            => check_op_256<uint>(ShiftOpKind.Sll);

        public void check_sll_64u()
            => check_op<ulong>(ShiftOpKind.Sll);

        public void check_sll_128x64u()
            => check_op_128<ulong>(ShiftOpKind.Sll);

        public void check_sll_256x64u()
            => check_op_256<ulong>(ShiftOpKind.Sll);

        // ~ srl

        public void check_srl_8u()
            => check_op<byte>(ShiftOpKind.Srl);

        public void check_srl_128x8u()
            => check_op_128<byte>(ShiftOpKind.Srl);

        public void check_srl_256x8u()
            => check_op_256<byte>(ShiftOpKind.Srl);

        public void check_srl_32u()
            => check_op<uint>(ShiftOpKind.Srl);

        public void check_srl_128x32u()
            => check_op_128<uint>(ShiftOpKind.Srl);

        public void check_srl_256x32u()
            => check_op_256<uint>(ShiftOpKind.Srl);

        public void check_srl_64u()
            => check_op<ulong>(ShiftOpKind.Srl);

        public void check_srl_128x64u()
            => check_op_128<ulong>(ShiftOpKind.Srl);

        public void check_srl_256x64u()
            => check_op_256<ulong>(ShiftOpKind.Srl);

        // ~ rotl

        public void check_rotl_8u()
            => check_op<byte>(ShiftOpKind.Rotl);

        public void check_rotl_128x8u()
            => check_op_128<byte>(ShiftOpKind.Rotl);

        public void check_rotl_256x8u()
            => check_op_256<byte>(ShiftOpKind.Rotl);

        public void check_rotl_32u()
            => check_op<uint>(ShiftOpKind.Rotl);

        public void check_rotl_128x32u()
            => check_op_128<uint>(ShiftOpKind.Rotl);

        public void check_rotl_256x32u()
            => check_op_256<uint>(ShiftOpKind.Rotl);

        public void check_rotl_64u()
            => check_op<ulong>(ShiftOpKind.Rotl);

        public void check_rotl_128x64u()
            => check_op_128<ulong>(ShiftOpKind.Rotl);

        public void check_rotl_256x64u()
            => check_op_256<ulong>(ShiftOpKind.Rotl);

        // ~ rotr

        public void check_rotr_8u()
            => check_op<byte>(ShiftOpKind.Rotr);

        public void check_rotr_128x8u()
            => check_op_128<byte>(ShiftOpKind.Rotr);

        public void check_rotr_256x8u()
            => check_op_256<byte>(ShiftOpKind.Rotr);

        public void check_rotr_16u()
            => check_op<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_128x16u()
            => check_op_128<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_256x16u()
            => check_op_256<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_32u()
            => check_op<uint>(ShiftOpKind.Rotr);

        public void check_rotr_128x32u()
            => check_op_128<uint>(ShiftOpKind.Rotr);

        public void check_rotr_256x32u()
            => check_op_256<uint>(ShiftOpKind.Rotr);

        public void check_rotr_64u()
            => check_op<ulong>(ShiftOpKind.Rotr);

        public void check_rotr_128x64u()
            => check_op_128<ulong>(ShiftOpKind.Rotr);

        public void check_rotr_256x64u()
            => check_op_256<ulong>(ShiftOpKind.Rotr);

        // ~ not

        public void eval_not_8u()
            => check_op<byte>(UnaryBitwiseOpKind.Not);

        public void eval_not_128x8u()
            => check_op_128<byte>(UnaryBitwiseOpKind.Not);

        public void eval_not_256x8u()
            => check_op_256<byte>(UnaryBitwiseOpKind.Not);

        public void eval_not_16u()
            => check_op<ushort>(UnaryBitwiseOpKind.Not);

        public void eval_not_128x16u()
            => check_op_128<ushort>(UnaryBitwiseOpKind.Not);

        public void eval_not_256x16u()
            => check_op_256<ushort>(UnaryBitwiseOpKind.Not);

        public void eval_not_32u()
            => check_op<uint>(UnaryBitwiseOpKind.Not);

        public void eval_not_128x32u()
            => check_op_128<uint>(UnaryBitwiseOpKind.Not);

        public void eval_not_256x32u()
            => check_op_256<uint>(UnaryBitwiseOpKind.Not);

        public void eval_not_64u()
            => check_op<ulong>(UnaryBitwiseOpKind.Not);

        public void eval_not_128x64u()
            => check_op_128<ulong>(UnaryBitwiseOpKind.Not);

        public void eval_not_256x64u()
            => check_op_256<ulong>(UnaryBitwiseOpKind.Not);

        // ~ ternary

        public void check_ternary_f01()
            => check_ops(TernaryBitOpKind.X01);

        public void check_ternary_f02()
            => check_ops(TernaryBitOpKind.X02);

        public void check_ternary_f03()
            => check_ops(TernaryBitOpKind.X03);

        public void check_ternary_f04()
            => check_ops(TernaryBitOpKind.X04);

        public void check_ternary_f05()
            => check_ops(TernaryBitOpKind.X05);

        public void check_ternary_f06()
            => check_ops(TernaryBitOpKind.X06);

        public void check_ternary_f07()
            => check_ops(TernaryBitOpKind.X07);

        public void check_ternary_f08()
            => check_ops(TernaryBitOpKind.X08);

        public void check_ternary_f09()
            => check_ops(TernaryBitOpKind.X09);

        public void check_ternary_f0a()
            => check_ops(TernaryBitOpKind.X0A);

        public void check_ternary_f0b()
            => check_ops(TernaryBitOpKind.X0B);

        public void check_ternary_f0c()
            => check_ops(TernaryBitOpKind.X0C);

        public void check_ternary_f0d()
            => check_ops(TernaryBitOpKind.X0D);

        public void check_ternary_f0e()
            => check_ops(TernaryBitOpKind.X0E);

        public void check_ternary_f0f()
            => check_ops(TernaryBitOpKind.X0F);

        public void check_ternary_f10()
            => check_ops(TernaryBitOpKind.X10);

        public void check_ternary_f11()
            => check_ops(TernaryBitOpKind.X11);
           
        public void check_ternary_f12()
            => check_ops(TernaryBitOpKind.X12);

        public void check_ternary_f13()
            => check_ops(TernaryBitOpKind.X13);


        void check_ops(TernaryBitOpKind op)
        {
            check_op<byte>(op);
            check_op<ushort>(op);
            check_op<uint>(op);
            check_op<ulong>(op);

        }

        void check_op<T>(UnaryBitwiseOpKind kind)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var expr = unary(kind,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);
                BitVector<T> actual = LogicEngine.eval(expr).Value;
                BitVector<T> expect = ScalarOpApi.eval(kind,a);
                Claim.eq(actual,expect);  
                                          
            }
        }

        void check_op<T>(BinaryBitwiseOpKind op)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var v2 = variable<T>(2);
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                v1.Set(a);
                v2.Set(b);
                T actual = LogicEngine.eval(expr);
                T expect = ScalarOpApi.eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_128<T>(UnaryBitwiseOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector128<T>();
                v1.Set(a);   
                Vector128<T> actual = LogicEngine.eval(expr);
                Vector128<T> expect = Cpu128OpApi.eval(op,a);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_256<T>(UnaryBitwiseOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector256<T>));
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector256<T>();
                v1.Set(a);   
                Vector256<T> actual = LogicEngine.eval(expr);
                Vector256<T> expect = Cpu256OpApi.eval(op,a);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_128<T>(BinaryBitwiseOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            var v2 = variable(2, default(Vector128<T>));
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector128<T>();
                var b = Random.CpuVector128<T>();
                v1.Set(a);   
                v2.Set(b);
                Vector128<T> actual = LogicEngine.eval(expr);
                Vector128<T> expect = Cpu128OpApi.eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_256<T>(BinaryBitwiseOpKind op)
            where T : unmanaged
        {
            
            var v1 = variable(1, default(Vector256<T>));
            var v2 = variable(2, default(Vector256<T>));
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector256<T>();
                var b = Random.CpuVector256<T>();
                v1.Set(a);   
                v2.Set(b);
                Vector256<T> actual = LogicEngine.eval(expr);
                Vector256<T> expect = Cpu256OpApi.eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);   
                T actual = LogicEngine.eval(expr);
                T expect = ScalarOpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_128<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector128<T>));
            var offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector128<T>();
                v1.Set(a);   
                Vector128<T> actual = LogicEngine.eval(expr);
                Vector128<T> expect = Cpu128OpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_256<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, default(Vector256<T>));
            var offset = 6;
            var expr = shift(op,v1,offset);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVector256<T>();
                v1.Set(a);   
                Vector256<T> actual = LogicEngine.eval(expr);
                Vector256<T> expect = Cpu256OpApi.eval(op,a,offset);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_identity<T>(TernaryBitOpKind id)
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

        void check_op<T>(TernaryBitOpKind id)
            where T : unmanaged
        {
            var BL = LogicOpApi.lookup(id);
            var SC = ScalarOpApi.lookup<T>(id);
            var V128 = Cpu128OpApi.lookup<T>(id);
            var V256 = Cpu256OpApi.lookup<T>(id);
            check_op_identity<T>(id);

            for(var sample = 0; sample< SampleSize; sample++)
            {
                var sa = Random.Next<T>();
                var sb = Random.Next<T>();
                var sc = Random.Next<T>();

                var z0 = BitVector.Generic<T>();
                var va = BitVector.Generic(sa);
                var vb = BitVector.Generic(sb);
                var vc = BitVector.Generic(sc);
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

    }

}