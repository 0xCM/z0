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
    using static  BitExprSpec;

    public class t_bitwise_eval : UnitTest<t_bitwise_eval>
    {
        // ~ and
        public void check_and_8u()
            => check_binary_op<byte>(BinaryLogicKind.And);
        public void check_and_16u()
            => check_binary_op<ushort>(BinaryLogicKind.And);
        public void check_and_32u()
            => check_binary_op<uint>(BinaryLogicKind.And);
        public void check_and_64u()
            => check_binary_op<ulong>(BinaryLogicKind.And);

        public void check_and_128x8u()
            => check_binary_op_128<byte>(BinaryLogicKind.And);

        public void check_and_128x16u()
            => check_binary_op_128<ushort>(BinaryLogicKind.And);

        public void check_and_128x32u()
            => check_binary_op_128<uint>(BinaryLogicKind.And);

        public void check_and_128x64u()
            => check_binary_op_128<ulong>(BinaryLogicKind.And);

        public void check_and_256x8u()
            => check_binary_op_256<byte>(BinaryLogicKind.And);

        public void check_and_256x16u()
            => check_binary_op_256<ushort>(BinaryLogicKind.And);

        public void check_and_256x32u()
            => check_binary_op_256<uint>(BinaryLogicKind.And);

        public void check_and_256x64u()
            => check_binary_op_256<ulong>(BinaryLogicKind.And);

        // ~ or

        public void check_or_8u()
            => check_binary_op<byte>(BinaryLogicKind.Or);

        public void check_or_128x8u()
            => check_binary_op_128<byte>(BinaryLogicKind.Or);

        public void check_or_256x8u()
            => check_binary_op_256<byte>(BinaryLogicKind.Or);

        public void check_or_32u()
            => check_binary_op<uint>(BinaryLogicKind.Or);

        public void check_or_128x32u()
            => check_binary_op_128<uint>(BinaryLogicKind.Or);

        public void check_or_256x32u()
            => check_binary_op_256<uint>(BinaryLogicKind.Or);

        public void check_or_64u()
            => check_binary_op<ulong>(BinaryLogicKind.Or);

        public void check_or_128x64u()
            => check_binary_op_128<ulong>(BinaryLogicKind.Or);

        public void check_or_256x64u()
            => check_binary_op_256<ulong>(BinaryLogicKind.Or);

        // ~ xor

        public void check_xor_8u()
            => check_binary_op<byte>(BinaryLogicKind.XOr);

        public void check_xor_128x8u()
            => check_binary_op_128<byte>(BinaryLogicKind.XOr);

        public void check_xor_256x8u()
            => check_binary_op_256<byte>(BinaryLogicKind.XOr);

        public void check_xor_32u()
            => check_binary_op<uint>(BinaryLogicKind.XOr);

        public void check_xor_128x32u()
            => check_binary_op_128<uint>(BinaryLogicKind.XOr);

        public void check_xor_256x32u()
            => check_binary_op_256<uint>(BinaryLogicKind.XOr);

        public void check_xor_64u()
            => check_binary_op<ulong>(BinaryLogicKind.XOr);

        public void check_xor_128x64u()
            => check_binary_op_128<ulong>(BinaryLogicKind.XOr);

        public void check_xor_256x64u()
            => check_binary_op_256<ulong>(BinaryLogicKind.XOr);

        // ~ sll

        public void check_sll_8u()
            => check_shift_op<byte>(ShiftOpKind.Sll);

        public void check_sll_128x8u()
            => check_shift_op_128<byte>(ShiftOpKind.Sll);

        public void check_sll_256x8u()
            => check_shift_op_256<byte>(ShiftOpKind.Sll);

        public void check_sll_32u()
            => check_shift_op<uint>(ShiftOpKind.Sll);

        public void check_sll_128x32u()
            => check_shift_op_128<uint>(ShiftOpKind.Sll);

        public void check_sll_256x32u()
            => check_shift_op_256<uint>(ShiftOpKind.Sll);

        public void check_sll_64u()
            => check_shift_op<ulong>(ShiftOpKind.Sll);

        public void check_sll_128x64u()
            => check_shift_op_128<ulong>(ShiftOpKind.Sll);

        public void check_sll_256x64u()
            => check_shift_op_256<ulong>(ShiftOpKind.Sll);

        // ~ srl

        public void check_srl_8u()
            => check_shift_op<byte>(ShiftOpKind.Srl);

        public void check_srl_128x8u()
            => check_shift_op_128<byte>(ShiftOpKind.Srl);

        public void check_srl_256x8u()
            => check_shift_op_256<byte>(ShiftOpKind.Srl);

        public void check_srl_32u()
            => check_shift_op<uint>(ShiftOpKind.Srl);

        public void check_srl_128x32u()
            => check_shift_op_128<uint>(ShiftOpKind.Srl);

        public void check_srl_256x32u()
            => check_shift_op_256<uint>(ShiftOpKind.Srl);

        public void check_srl_64u()
            => check_shift_op<ulong>(ShiftOpKind.Srl);

        public void check_srl_128x64u()
            => check_shift_op_128<ulong>(ShiftOpKind.Srl);

        public void check_srl_256x64u()
            => check_shift_op_256<ulong>(ShiftOpKind.Srl);

        // ~ rotl

        public void check_rotl_8u()
            => check_shift_op<byte>(ShiftOpKind.Rotl);

        public void check_rotl_128x8u()
            => check_shift_op_128<byte>(ShiftOpKind.Rotl);

        public void check_rotl_256x8u()
            => check_shift_op_256<byte>(ShiftOpKind.Rotl);

        public void check_rotl_32u()
            => check_shift_op<uint>(ShiftOpKind.Rotl);

        public void check_rotl_128x32u()
            => check_shift_op_128<uint>(ShiftOpKind.Rotl);

        public void check_rotl_256x32u()
            => check_shift_op_256<uint>(ShiftOpKind.Rotl);

        public void check_rotl_64u()
            => check_shift_op<ulong>(ShiftOpKind.Rotl);

        public void check_rotl_128x64u()
            => check_shift_op_128<ulong>(ShiftOpKind.Rotl);

        public void check_rotl_256x64u()
            => check_shift_op_256<ulong>(ShiftOpKind.Rotl);

        // ~ rotl

        public void check_rotr_8u()
            => check_shift_op<byte>(ShiftOpKind.Rotr);

        public void check_rotr_128x8u()
            => check_shift_op_128<byte>(ShiftOpKind.Rotr);

        public void check_rotr_256x8u()
            => check_shift_op_256<byte>(ShiftOpKind.Rotr);

        public void check_rotr_16u()
            => check_shift_op<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_128x16u()
            => check_shift_op_128<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_256x16u()
            => check_shift_op_256<ushort>(ShiftOpKind.Rotr);

        public void check_rotr_32u()
            => check_shift_op<uint>(ShiftOpKind.Rotr);

        public void check_rotr_128x32u()
            => check_shift_op_128<uint>(ShiftOpKind.Rotr);

        public void check_rotr_256x32u()
            => check_shift_op_256<uint>(ShiftOpKind.Rotr);

        public void check_rotr_64u()
            => check_shift_op<ulong>(ShiftOpKind.Rotr);

        public void check_rotr_128x64u()
            => check_shift_op_128<ulong>(ShiftOpKind.Rotr);

        public void check_rotr_256x64u()
            => check_shift_op_256<ulong>(ShiftOpKind.Rotr);

        // ~ not

        public void eval_not_8u()
            => check_unary_op<byte>(UnaryLogicKind.Not);

        public void eval_not_128x8u()
            => check_unary_op_128<byte>(UnaryLogicKind.Not);

        public void eval_not_256x8u()
            => check_unary_op_256<byte>(UnaryLogicKind.Not);

        public void eval_not_16u()
            => check_unary_op<ushort>(UnaryLogicKind.Not);

        public void eval_not_128x16u()
            => check_unary_op_128<ushort>(UnaryLogicKind.Not);

        public void eval_not_256x16u()
            => check_unary_op_256<ushort>(UnaryLogicKind.Not);

        public void eval_not_32u()
            => check_unary_op<uint>(UnaryLogicKind.Not);

        public void eval_not_128x32u()
            => check_unary_op_128<uint>(UnaryLogicKind.Not);

        public void eval_not_256x32u()
            => check_unary_op_256<uint>(UnaryLogicKind.Not);

        public void eval_not_64u()
            => check_unary_op<ulong>(UnaryLogicKind.Not);

        public void eval_not_128x64u()
            => check_unary_op_128<ulong>(UnaryLogicKind.Not);

        public void eval_not_256x64u()
            => check_unary_op_256<ulong>(UnaryLogicKind.Not);


        T eval_unaryop<T>(UnaryLogicKind op, T lhs)
            where T : unmanaged
        {
            switch(op)
            {
                case UnaryLogicKind.Not:
                    return gmath.not(lhs);
                case UnaryLogicKind.Negate:
                    return gmath.negate(lhs);
            }
            return default;
        }

        T eval_shift_op<T>(ShiftOpKind op, T lhs, int rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case ShiftOpKind.Sll:
                    return gmath.sll(lhs,rhs);
                case ShiftOpKind.Srl:
                    return gmath.srl(lhs,rhs);
                case ShiftOpKind.Rotl:
                    return gbits.rotl(lhs,rhs);
                case ShiftOpKind.Rotr:
                    return gbits.rotr(lhs,rhs);

            }
            return default;
        }

        Vec128<T> eval_unary_op<T>(UnaryLogicKind op, Vec128<T> lhs)
            where T : unmanaged
        {
            switch(op)
            {
                case UnaryLogicKind.Not:
                    return ginx.vnot(lhs);
                case UnaryLogicKind.Negate:
                    return ginx.vnegate(lhs);
            }
            return default;
        }

        Vec256<T> eval_unary_op<T>(UnaryLogicKind op, Vec256<T> lhs)
            where T : unmanaged
        {
            switch(op)
            {
                case UnaryLogicKind.Not:
                    return ginx.vnot(lhs);
                case UnaryLogicKind.Negate:
                    return ginx.vnegate(lhs);
            }
            return default;
        }

        Vec128<T> eval_shift_op<T>(ShiftOpKind op, Vec128<T> lhs, int rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case ShiftOpKind.Sll:
                    return ginx.vsll(lhs,(byte)rhs);
                case ShiftOpKind.Srl:
                    return ginx.vsrl(lhs,(byte)rhs);
                case ShiftOpKind.Rotl:
                    return ginx.vrotl(lhs,(byte)rhs);
                case ShiftOpKind.Rotr:
                    return ginx.vrotr(lhs,(byte)rhs);

            }
            return default;
        }

        Vec256<T> eval_shift_op<T>(ShiftOpKind op, Vec256<T> lhs, int rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case ShiftOpKind.Sll:
                    return ginx.vsll(lhs,(byte)rhs);
                case ShiftOpKind.Srl:
                    return ginx.vsrl(lhs,(byte)rhs);
                case ShiftOpKind.Rotl:
                    return ginx.vrotl(lhs,(byte)rhs);
                case ShiftOpKind.Rotr:
                    return ginx.vrotr(lhs,(byte)rhs);

            }
            return default;
        }

        T eval_binary_op<T>(BinaryLogicKind op, T lhs, T rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicKind.And:
                    return gmath.and(lhs,rhs);
                case BinaryLogicKind.Or:
                    return gmath.or(lhs,rhs);
                case BinaryLogicKind.XOr:
                    return gmath.xor(lhs,rhs);
            }
            return default;
        }

        Vec128<T> eval_binary_op<T>(BinaryLogicKind op, Vec128<T> lhs, Vec128<T> rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicKind.And:
                    return ginx.vand(lhs,rhs);
                case BinaryLogicKind.Or:
                    return ginx.vor(lhs,rhs);
                case BinaryLogicKind.XOr:
                    return ginx.vxor(lhs,rhs);
            }
            return default;
        }

        Vec256<T> eval_binary_op<T>(BinaryLogicKind op, Vec256<T> lhs, Vec256<T> rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BinaryLogicKind.And:
                    return ginx.vand(lhs,rhs);
                case BinaryLogicKind.Or:
                    return ginx.vor(lhs,rhs);
                case BinaryLogicKind.XOr:
                    return ginx.vxor(lhs,rhs);
            }
            return default;
        }

        void check_binary_op<T>(BinaryLogicKind op)
            where T : unmanaged
        {
            var v1 = bitvar<T>(1);
            var v2 = bitvar<T>(2);
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next<T>();
                v1.Set(a);
                v2.Set(b);
                T actual = BitExpr.eval(expr);
                T expect = eval_binary_op(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_unary_op<T>(UnaryLogicKind op)
            where T : unmanaged
        {
            var v1 = bitvar<T>(1);
            var expr = unary<T>(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);   
                T actual = BitExpr.eval(expr);
                T expect = eval_unaryop(op,a);
                Claim.eq(actual,expect);                            
            }
        }

        void check_unary_op_128<T>(UnaryLogicKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec128<T>.Zero);
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                v1.Set(a);   
                Vec128<T> actual = BitExpr.eval(expr);
                Vec128<T> expect = eval_unary_op(op,a);
                Claim.eq(actual,expect);                            
            }
        }

        void check_unary_op_256<T>(UnaryLogicKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec256<T>.Zero);
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                v1.Set(a);   
                Vec256<T> actual = BitExpr.eval(expr);
                Vec256<T> expect = eval_unary_op(op,a);
                Claim.eq(actual,expect);                            
            }
        }


        void check_binary_op_128<T>(BinaryLogicKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec128<T>.Zero);
            var v2 = bitvar(2, Vec128<T>.Zero);
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                var b = Random.CpuVec128<T>();
                v1.Set(a);   
                v2.Set(b);
                Vec128<T> actual = BitExpr.eval(expr);
                Vec128<T> expect = eval_binary_op(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_binary_op_256<T>(BinaryLogicKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec256<T>.Zero);
            var v2 = bitvar(2, Vec256<T>.Zero);
            var expr = binary(op,v1,v2);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                var b = Random.CpuVec256<T>();
                v1.Set(a);   
                v2.Set(b);
                Vec256<T> actual = BitExpr.eval(expr);
                Vec256<T> expect = eval_binary_op(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_shift_op<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar<T>(1);
            var v2 = bitvar(2, 0);
            var expr = shift(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                T actual = BitExpr.eval(expr);
                T expect = eval_shift_op(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_shift_op_128<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec128<T>.Zero);
            var v2 = bitvar(2, 0);
            var expr = shift(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                Vec128<T> actual = BitExpr.eval(expr);
                Vec128<T> expect = eval_shift_op(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_shift_op_256<T>(ShiftOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec256<T>.Zero);
            var v2 = bitvar(2, 0);
            var expr = shift(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                Vec256<T> actual = BitExpr.eval(expr);
                Vec256<T> expect = eval_shift_op(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }
    }

}