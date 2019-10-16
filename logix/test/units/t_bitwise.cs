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
            => check_binop<byte>(BitOpKind.And);
        public void check_and_16u()
            => check_binop<ushort>(BitOpKind.And);
        public void check_and_32u()
            => check_binop<uint>(BitOpKind.And);
        public void check_and_64u()
            => check_binop<ulong>(BitOpKind.And);

        public void check_and_128x8u()
            => check_binop_128<byte>(BitOpKind.And);

        public void check_and_128x16u()
            => check_binop_128<ushort>(BitOpKind.And);

        public void check_and_128x32u()
            => check_binop_128<uint>(BitOpKind.And);

        public void check_and_128x64u()
            => check_binop_128<ulong>(BitOpKind.And);

        public void check_and_256x8u()
            => check_binop_256<byte>(BitOpKind.And);

        public void check_and_256x16u()
            => check_binop_256<ushort>(BitOpKind.And);

        public void check_and_256x32u()
            => check_binop_256<uint>(BitOpKind.And);

        public void check_and_256x64u()
            => check_binop_256<ulong>(BitOpKind.And);

        // ~ or

        public void check_or_8u()
            => check_binop<byte>(BitOpKind.Or);

        public void check_or_128x8u()
            => check_binop_128<byte>(BitOpKind.Or);

        public void check_or_256x8u()
            => check_binop_256<byte>(BitOpKind.Or);

        public void check_or_32u()
            => check_binop<uint>(BitOpKind.Or);

        public void check_or_128x32u()
            => check_binop_128<uint>(BitOpKind.Or);

        public void check_or_256x32u()
            => check_binop_256<uint>(BitOpKind.Or);

        public void check_or_64u()
            => check_binop<ulong>(BitOpKind.Or);

        public void check_or_128x64u()
            => check_binop_128<ulong>(BitOpKind.Or);

        public void check_or_256x64u()
            => check_binop_256<ulong>(BitOpKind.Or);

        // ~ xor

        public void check_xor_8u()
            => check_binop<byte>(BitOpKind.XOr);

        public void check_xor_128x8u()
            => check_binop_128<byte>(BitOpKind.XOr);

        public void check_xor_256x8u()
            => check_binop_256<byte>(BitOpKind.XOr);

        public void check_xor_32u()
            => check_binop<uint>(BitOpKind.XOr);

        public void check_xor_128x32u()
            => check_binop_128<uint>(BitOpKind.XOr);

        public void check_xor_256x32u()
            => check_binop_256<uint>(BitOpKind.XOr);

        public void check_xor_64u()
            => check_binop<ulong>(BitOpKind.XOr);

        public void check_xor_128x64u()
            => check_binop_128<ulong>(BitOpKind.XOr);

        public void check_xor_256x64u()
            => check_binop_256<ulong>(BitOpKind.XOr);

        // ~ sll

        public void check_sll_8u()
            => check_mixedop<byte>(BitOpKind.Sll);

        public void check_sll_128x8u()
            => check_mixedop_128<byte>(BitOpKind.Sll);

        public void check_sll_256x8u()
            => check_mixedop_256<byte>(BitOpKind.Sll);

        public void check_sll_32u()
            => check_mixedop<uint>(BitOpKind.Sll);

        public void check_sll_128x32u()
            => check_mixedop_128<uint>(BitOpKind.Sll);

        public void check_sll_256x32u()
            => check_mixedop_256<uint>(BitOpKind.Sll);

        public void check_sll_64u()
            => check_mixedop<ulong>(BitOpKind.Sll);

        public void check_sll_128x64u()
            => check_mixedop_128<ulong>(BitOpKind.Sll);

        public void check_sll_256x64u()
            => check_mixedop_256<ulong>(BitOpKind.Sll);

        // ~ srl

        public void check_srl_8u()
            => check_mixedop<byte>(BitOpKind.Srl);

        public void check_srl_128x8u()
            => check_mixedop_128<byte>(BitOpKind.Srl);

        public void check_srl_256x8u()
            => check_mixedop_256<byte>(BitOpKind.Srl);

        public void check_srl_32u()
            => check_mixedop<uint>(BitOpKind.Srl);

        public void check_srl_128x32u()
            => check_mixedop_128<uint>(BitOpKind.Srl);

        public void check_srl_256x32u()
            => check_mixedop_256<uint>(BitOpKind.Srl);

        public void check_srl_64u()
            => check_mixedop<ulong>(BitOpKind.Srl);

        public void check_srl_128x64u()
            => check_mixedop_128<ulong>(BitOpKind.Srl);

        public void check_srl_256x64u()
            => check_mixedop_256<ulong>(BitOpKind.Srl);

        // ~ rotl

        public void check_rotl_8u()
            => check_mixedop<byte>(BitOpKind.Rotl);

        public void check_rotl_128x8u()
            => check_mixedop_128<byte>(BitOpKind.Rotl);

        public void check_rotl_256x8u()
            => check_mixedop_256<byte>(BitOpKind.Rotl);

        public void check_rotl_32u()
            => check_mixedop<uint>(BitOpKind.Rotl);

        public void check_rotl_128x32u()
            => check_mixedop_128<uint>(BitOpKind.Rotl);

        public void check_rotl_256x32u()
            => check_mixedop_256<uint>(BitOpKind.Rotl);

        public void check_rotl_64u()
            => check_mixedop<ulong>(BitOpKind.Rotl);

        public void check_rotl_128x64u()
            => check_mixedop_128<ulong>(BitOpKind.Rotl);

        public void check_rotl_256x64u()
            => check_mixedop_256<ulong>(BitOpKind.Rotl);

        // ~ rotl

        public void check_rotr_8u()
            => check_mixedop<byte>(BitOpKind.Rotr);

        public void check_rotr_128x8u()
            => check_mixedop_128<byte>(BitOpKind.Rotr);

        public void check_rotr_256x8u()
            => check_mixedop_256<byte>(BitOpKind.Rotr);

        public void check_rotr_16u()
            => check_mixedop<ushort>(BitOpKind.Rotr);

        public void check_rotr_128x16u()
            => check_mixedop_128<ushort>(BitOpKind.Rotr);

        public void check_rotr_256x16u()
            => check_mixedop_256<ushort>(BitOpKind.Rotr);

        public void check_rotr_32u()
            => check_mixedop<uint>(BitOpKind.Rotr);

        public void check_rotr_128x32u()
            => check_mixedop_128<uint>(BitOpKind.Rotr);

        public void check_rotr_256x32u()
            => check_mixedop_256<uint>(BitOpKind.Rotr);

        public void check_rotr_64u()
            => check_mixedop<ulong>(BitOpKind.Rotr);

        public void check_rotr_128x64u()
            => check_mixedop_128<ulong>(BitOpKind.Rotr);

        public void check_rotr_256x64u()
            => check_mixedop_256<ulong>(BitOpKind.Rotr);

        // ~ not

        public void eval_not_8u()
            => check_unaryop<byte>(BitOpKind.Not);

        public void eval_not_128x8u()
            => check_unaryop_128<byte>(BitOpKind.Not);

        public void eval_not_256x8u()
            => check_unaryop_256<byte>(BitOpKind.Not);

        public void eval_not_16u()
            => check_unaryop<ushort>(BitOpKind.Not);

        public void eval_not_128x16u()
            => check_unaryop_128<ushort>(BitOpKind.Not);

        public void eval_not_256x16u()
            => check_unaryop_256<ushort>(BitOpKind.Not);

        public void eval_not_32u()
            => check_unaryop<uint>(BitOpKind.Not);

        public void eval_not_128x32u()
            => check_unaryop_128<uint>(BitOpKind.Not);

        public void eval_not_256x32u()
            => check_unaryop_256<uint>(BitOpKind.Not);

        public void eval_not_64u()
            => check_unaryop<ulong>(BitOpKind.Not);

        public void eval_not_128x64u()
            => check_unaryop_128<ulong>(BitOpKind.Not);

        public void eval_not_256x64u()
            => check_unaryop_256<ulong>(BitOpKind.Not);

        // ~ negate

        public void eval_negate_8u()
            => check_unaryop<byte>(BitOpKind.Negate);

        public void eval_negate_128x8u()
            => check_unaryop_128<byte>(BitOpKind.Negate);

        public void eval_negate_256x8u()
            => check_unaryop_256<byte>(BitOpKind.Negate);

        public void eval_negate_16u()
            => check_unaryop<ushort>(BitOpKind.Negate);

        public void eval_negate_128x16u()
            => check_unaryop_128<ushort>(BitOpKind.Negate);

        public void eval_negate_256x16u()
            => check_unaryop_256<ushort>(BitOpKind.Negate);

        public void eval_negate_32u()
            => check_unaryop<uint>(BitOpKind.Negate);

        public void eval_negate_128x32u()
            => check_unaryop_128<uint>(BitOpKind.Negate);

        public void eval_negate_256x32u()
            => check_unaryop_256<uint>(BitOpKind.Negate);

        public void eval_negate_64u()
            => check_unaryop<ulong>(BitOpKind.Negate);

        public void eval_negate_128x64u()
            => check_unaryop_128<ulong>(BitOpKind.Negate);

        public void eval_negate_256x64u()
            => check_unaryop_256<ulong>(BitOpKind.Negate);

        T eval_unaryop<T>(BitOpKind op, T lhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.Not:
                    return gmath.not(lhs);
                case BitOpKind.Negate:
                    return gmath.negate(lhs);
            }
            return default;
        }

        T eval_mixedop<T>(BitOpKind op, T lhs, int rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.Sll:
                    return gmath.sll(lhs,rhs);
                case BitOpKind.Srl:
                    return gmath.srl(lhs,rhs);
                case BitOpKind.Rotl:
                    return gbits.rotl(lhs,rhs);
                case BitOpKind.Rotr:
                    return gbits.rotr(lhs,rhs);

            }
            return default;
        }

        Vec128<T> eval_vunaryop<T>(BitOpKind op, Vec128<T> lhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.Not:
                    return ginx.vnot(lhs);
                case BitOpKind.Negate:
                    return ginx.vnegate(lhs);
            }
            return default;
        }

        Vec256<T> eval_vunaryop<T>(BitOpKind op, Vec256<T> lhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.Not:
                    return ginx.vnot(lhs);
                case BitOpKind.Negate:
                    return ginx.vnegate(lhs);
            }
            return default;
        }

        Vec128<T> eval_vmixedop<T>(BitOpKind op, Vec128<T> lhs, int rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.Sll:
                    return ginx.vsll(lhs,(byte)rhs);
                case BitOpKind.Srl:
                    return ginx.vsrl(lhs,(byte)rhs);
                case BitOpKind.Rotl:
                    return ginx.vrotl(lhs,(byte)rhs);
                case BitOpKind.Rotr:
                    return ginx.vrotr(lhs,(byte)rhs);

            }
            return default;
        }

        Vec256<T> eval_vmixedop<T>(BitOpKind op, Vec256<T> lhs, int rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.Sll:
                    return ginx.vsll(lhs,(byte)rhs);
                case BitOpKind.Srl:
                    return ginx.vsrl(lhs,(byte)rhs);
                case BitOpKind.Rotl:
                    return ginx.vrotl(lhs,(byte)rhs);
                case BitOpKind.Rotr:
                    return ginx.vrotr(lhs,(byte)rhs);

            }
            return default;
        }

        T eval_binop<T>(BitOpKind op, T lhs, T rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.And:
                    return gmath.and(lhs,rhs);
                case BitOpKind.Or:
                    return gmath.or(lhs,rhs);
                case BitOpKind.XOr:
                    return gmath.xor(lhs,rhs);
            }
            return default;
        }

        Vec128<T> eval_vbinop<T>(BitOpKind op, Vec128<T> lhs, Vec128<T> rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.And:
                    return ginx.vand(lhs,rhs);
                case BitOpKind.Or:
                    return ginx.vor(lhs,rhs);
                case BitOpKind.XOr:
                    return ginx.vxor(lhs,rhs);
            }
            return default;
        }

        Vec256<T> eval_vbinop<T>(BitOpKind op, Vec256<T> lhs, Vec256<T> rhs)
            where T : unmanaged
        {
            switch(op)
            {
                case BitOpKind.And:
                    return ginx.vand(lhs,rhs);
                case BitOpKind.Or:
                    return ginx.vor(lhs,rhs);
                case BitOpKind.XOr:
                    return ginx.vxor(lhs,rhs);
            }
            return default;
        }

        void check_binop<T>(BitOpKind op)
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
                T expect = eval_binop(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_unaryop<T>(BitOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar<T>(1);
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                v1.Set(a);   
                T actual = BitExpr.eval(expr);
                T expect = eval_unaryop(op,a);
                Claim.eq(actual,expect);                            
            }
        }

        void check_unaryop_128<T>(BitOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec128<T>.Zero);
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                v1.Set(a);   
                Vec128<T> actual = BitExpr.eval(expr);
                Vec128<T> expect = eval_vunaryop(op,a);
                Claim.eq(actual,expect);                            
            }
        }

        void check_unaryop_256<T>(BitOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec256<T>.Zero);
            var expr = unary(op,v1);
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                v1.Set(a);   
                Vec256<T> actual = BitExpr.eval(expr);
                Vec256<T> expect = eval_vunaryop(op,a);
                Claim.eq(actual,expect);                            
            }
        }


        void check_binop_128<T>(BitOpKind op)
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
                Vec128<T> expect = eval_vbinop(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_binop_256<T>(BitOpKind op)
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
                Vec256<T> expect = eval_vbinop(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_mixedop<T>(BitOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar<T>(1);
            var v2 = bitvar(2, 0);
            var expr = mixed(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.Next<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                T actual = BitExpr.eval(expr);
                T expect = eval_mixedop(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }

        void check_mixedop_128<T>(BitOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec128<T>.Zero);
            var v2 = bitvar(2, 0);
            var expr = mixed(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec128<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                Vec128<T> actual = BitExpr.eval(expr);
                Vec128<T> expect = eval_vmixedop(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }



        void check_mixedop_256<T>(BitOpKind op)
            where T : unmanaged
        {
            var v1 = bitvar(1, Vec256<T>.Zero);
            var v2 = bitvar(2, 0);
            var expr = mixed(op,v1,v2);
            var minoffset = 2;
            var maxoffset = bitsize<T>() - 2;
            
            for(var i=0; i< SampleSize; i++)
            {
                var a = Random.CpuVec256<T>();
                var b = Random.Next(minoffset, maxoffset);
                v1.Set(a);   
                v2.Set(b);
                Vec256<T> actual = BitExpr.eval(expr);
                Vec256<T> expect = eval_vmixedop(op,a,b);
                Claim.eq(actual,expect);                            
            }
        }


    }

}