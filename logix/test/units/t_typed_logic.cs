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
    using static TypedLogicSpec;
    using static VectorOpEval;
    using static ScalarOpEval;

    public class t_typed_logic : UnitTest<t_typed_logic>
    {
        // ~ and
        public void check_and_8u()
            => check_op<byte>(BinaryLogicOpKind.And);

        public void check_and_16u()
            => check_op<ushort>(BinaryLogicOpKind.And);
        public void check_and_32u()
            => check_op<uint>(BinaryLogicOpKind.And);
        public void check_and_64u()
            => check_op<ulong>(BinaryLogicOpKind.And);

        public void check_and_128x8u()
            => check_op_128<byte>(BinaryLogicOpKind.And);

        public void check_and_128x16u()
            => check_op_128<ushort>(BinaryLogicOpKind.And);

        public void check_and_128x32u()
            => check_op_128<uint>(BinaryLogicOpKind.And);

        public void check_and_128x64u()
            => check_op_128<ulong>(BinaryLogicOpKind.And);

        public void check_and_256x8u()
            => check_op_256<byte>(BinaryLogicOpKind.And);

        public void check_and_256x16u()
            => check_op_256<ushort>(BinaryLogicOpKind.And);

        public void check_and_256x32u()
            => check_op_256<uint>(BinaryLogicOpKind.And);

        public void check_and_256x64u()
            => check_op_256<ulong>(BinaryLogicOpKind.And);

        // ~ nand
        public void check_nand_8u()
            => check_op<byte>(BinaryLogicOpKind.Nand);

        public void check_nand_16u()
            => check_op<ushort>(BinaryLogicOpKind.Nand);
        
        public void check_nand_32u()
            => check_op<uint>(BinaryLogicOpKind.Nand);
        
        public void check_nand_64u()
            => check_op<ulong>(BinaryLogicOpKind.Nand);

        public void check_nand_128x8u()
            => check_op_128<byte>(BinaryLogicOpKind.Nand);

        public void check_nand_128x16u()
            => check_op_128<ushort>(BinaryLogicOpKind.Nand);

        public void check_nand_128x32u()
            => check_op_128<uint>(BinaryLogicOpKind.Nand);

        public void check_nand_128x64u()
            => check_op_128<ulong>(BinaryLogicOpKind.Nand);

        public void check_nand_256x8u()
            => check_op_256<byte>(BinaryLogicOpKind.Nand);

        public void check_nand_256x16u()
            => check_op_256<ushort>(BinaryLogicOpKind.Nand);

        public void check_nand_256x32u()
            => check_op_256<uint>(BinaryLogicOpKind.Nand);

        public void check_nand_256x64u()
            => check_op_256<ulong>(BinaryLogicOpKind.Nand);
        
        // ~ or
        public void check_or_8u()
            => check_op<byte>(BinaryLogicOpKind.Or);

        public void check_or_128x8u()
            => check_op_128<byte>(BinaryLogicOpKind.Or);

        public void check_or_256x8u()
            => check_op_256<byte>(BinaryLogicOpKind.Or);

        public void check_or_16u()
            => check_op<ushort>(BinaryLogicOpKind.Or);

        public void check_or_128x16u()
            => check_op_128<ushort>(BinaryLogicOpKind.Or);

        public void check_or_256x16u()
            => check_op_256<ushort>(BinaryLogicOpKind.Or);

        public void check_or_32u()
            => check_op<uint>(BinaryLogicOpKind.Or);

        public void check_or_128x32u()
            => check_op_128<uint>(BinaryLogicOpKind.Or);

        public void check_or_256x32u()
            => check_op_256<uint>(BinaryLogicOpKind.Or);

        public void check_or_64u()
            => check_op<ulong>(BinaryLogicOpKind.Or);

        public void check_or_128x64u()
            => check_op_128<ulong>(BinaryLogicOpKind.Or);

        public void check_or_256x64u()
            => check_op_256<ulong>(BinaryLogicOpKind.Or);

        // ~ nor
        public void check_nor_8u()
            => check_op<byte>(BinaryLogicOpKind.Nor);

        public void check_nor_128x8u()
            => check_op_128<byte>(BinaryLogicOpKind.Nor);

        public void check_nor_256x8u()
            => check_op_256<byte>(BinaryLogicOpKind.Nor);

        public void check_nor_16u()
            => check_op<ushort>(BinaryLogicOpKind.Nor);

        public void check_nor_128x16u()
            => check_op_128<ushort>(BinaryLogicOpKind.Nor);

        public void check_nor_256x16u()
            => check_op_256<ushort>(BinaryLogicOpKind.Nor);

        public void check_nor_32u()
            => check_op<uint>(BinaryLogicOpKind.Nor);

        public void check_nor_128x32u()
            => check_op_128<uint>(BinaryLogicOpKind.Nor);

        public void check_nor_256x32u()
            => check_op_256<uint>(BinaryLogicOpKind.Nor);

        public void check_nor_64u()
            => check_op<ulong>(BinaryLogicOpKind.Nor);

        public void check_nor_128x64u()
            => check_op_128<ulong>(BinaryLogicOpKind.Nor);

        public void check_nor_256x64u()
            => check_op_256<ulong>(BinaryLogicOpKind.Nor);

        // ~ xor

        public void check_xor_8u()
            => check_op<byte>(BinaryLogicOpKind.XOr);

        public void check_xor_128x8u()
            => check_op_128<byte>(BinaryLogicOpKind.XOr);

        public void check_xor_256x8u()
            => check_op_256<byte>(BinaryLogicOpKind.XOr);

        public void check_xor_16u()
            => check_op<ushort>(BinaryLogicOpKind.XOr);

        public void check_xor_128x16u()
            => check_op_128<ushort>(BinaryLogicOpKind.XOr);

        public void check_xor_256x16u()
            => check_op_256<ushort>(BinaryLogicOpKind.XOr);

        public void check_xor_32u()
            => check_op<uint>(BinaryLogicOpKind.XOr);

        public void check_xor_128x32u()
            => check_op_128<uint>(BinaryLogicOpKind.XOr);

        public void check_xor_256x32u()
            => check_op_256<uint>(BinaryLogicOpKind.XOr);

        public void check_xor_64u()
            => check_op<ulong>(BinaryLogicOpKind.XOr);

        public void check_xor_128x64u()
            => check_op_128<ulong>(BinaryLogicOpKind.XOr);

        public void check_xor_256x64u()
            => check_op_256<ulong>(BinaryLogicOpKind.XOr);

        // ~ xnor

        public void check_xnor_8u()
            => check_op<byte>(BinaryLogicOpKind.Xnor);

        public void check_xnor_128x8u()
            => check_op_128<byte>(BinaryLogicOpKind.Xnor);

        public void check_xnor_256x8u()
            => check_op_256<byte>(BinaryLogicOpKind.Xnor);

        public void check_xnor_16u()
            => check_op<ushort>(BinaryLogicOpKind.Xnor);

        public void check_xnor_128x16u()
            => check_op_128<ushort>(BinaryLogicOpKind.Xnor);

        public void check_xnor_256x16u()
            => check_op_256<ushort>(BinaryLogicOpKind.Xnor);

        public void check_xnor_32u()
            => check_op<uint>(BinaryLogicOpKind.Xnor);

        public void check_xnor_128x32u()
            => check_op_128<uint>(BinaryLogicOpKind.Xnor);

        public void check_xnor_256x32u()
            => check_op_256<uint>(BinaryLogicOpKind.Xnor);

        public void check_xnor_64u()
            => check_op<ulong>(BinaryLogicOpKind.Xnor);

        public void check_xnor_128x64u()
            => check_op_128<ulong>(BinaryLogicOpKind.Xnor);

        public void check_xnor_256x64u()
            => check_op_256<ulong>(BinaryLogicOpKind.Xnor);

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

        // ~ rotl

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
            => check_op<byte>(UnaryLogicOpKind.Not);

        public void eval_not_128x8u()
            => check_op_128<byte>(UnaryLogicOpKind.Not);

        public void eval_not_256x8u()
            => check_op_256<byte>(UnaryLogicOpKind.Not);

        public void eval_not_16u()
            => check_op<ushort>(UnaryLogicOpKind.Not);

        public void eval_not_128x16u()
            => check_op_128<ushort>(UnaryLogicOpKind.Not);

        public void eval_not_256x16u()
            => check_op_256<ushort>(UnaryLogicOpKind.Not);

        public void eval_not_32u()
            => check_op<uint>(UnaryLogicOpKind.Not);

        public void eval_not_128x32u()
            => check_op_128<uint>(UnaryLogicOpKind.Not);

        public void eval_not_256x32u()
            => check_op_256<uint>(UnaryLogicOpKind.Not);

        public void eval_not_64u()
            => check_op<ulong>(UnaryLogicOpKind.Not);

        public void eval_not_128x64u()
            => check_op_128<ulong>(UnaryLogicOpKind.Not);

        public void eval_not_256x64u()
            => check_op_256<ulong>(UnaryLogicOpKind.Not);


        void check_op<T>(BinaryLogicOpKind op)
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
                T expect = eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op<T>(UnaryLogicOpKind op)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var expr = unary<T>(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);   
                T actual = LogicEngine.eval(expr);
                T expect = eval(op,a);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_128<T>(UnaryLogicOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, Vec128<T>.Zero);
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                v1.Set(a);   
                Vec128<T> actual = LogicEngine.eval(expr);
                Vec128<T> expect = eval(op,a);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_256<T>(UnaryLogicOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, Vec256<T>.Zero);
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                v1.Set(a);   
                Vec256<T> actual = LogicEngine.eval(expr);
                Vec256<T> expect = eval(op,a);
                Claim.eq(actual,expect);                            
            }
        }


        void check_op_128<T>(BinaryLogicOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, Vec128<T>.Zero);
            var v2 = variable(2, Vec128<T>.Zero);
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                var b = Random.CpuVec128<T>();
                v1.Set(a);   
                v2.Set(b);
                Vec128<T> actual = LogicEngine.eval(expr);
                Vec128<T> expect = eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_256<T>(BinaryLogicOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, Vec256<T>.Zero);
            var v2 = variable(2, Vec256<T>.Zero);
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                var b = Random.CpuVec256<T>();
                v1.Set(a);   
                v2.Set(b);
                Vec256<T> actual = LogicEngine.eval(expr);
                Vec256<T> expect = eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable<T>(1);
            var v2 = variable(2, 0);
            var expr = shift(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                T actual = LogicEngine.eval(expr);
                T expect = eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_128<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, Vec128<T>.Zero);
            var v2 = variable(2, 0);
            var expr = shift(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                Vec128<T> actual = LogicEngine.eval(expr);
                Vec128<T> expect = eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_op_256<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = variable(1, Vec256<T>.Zero);
            var v2 = variable(2, 0);
            var expr = shift(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                Vec256<T> actual = LogicEngine.eval(expr);
                Vec256<T> expect = eval(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }
    }

}