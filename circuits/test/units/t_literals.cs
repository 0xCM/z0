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
    using static  Bitwise;


    public class t_literals : UnitTest<t_literals>
    {
        // ~ and

        public void eval_and_8u()
            => eval_scalar_binop_check<byte>(BitOpKind.And);

        public void eval_and_128x8u()
            => eval_vec128_binop_check<byte>(BitOpKind.And);

        public void eval_and_256x8u()
            => eval_vec256_binop_check<byte>(BitOpKind.And);

        public void eval_and_16u()
            => eval_scalar_binop_check<ushort>(BitOpKind.And);

        public void eval_and_128x16u()
            => eval_vec128_binop_check<ushort>(BitOpKind.And);

        public void eval_and_256x16u()
            => eval_vec256_binop_check<ushort>(BitOpKind.And);

        public void eval_and_32u()
            => eval_scalar_binop_check<uint>(BitOpKind.And);

        public void eval_and_128x32u()
            => eval_vec128_binop_check<uint>(BitOpKind.And);

        public void eval_and_256x32u()
            => eval_vec256_binop_check<uint>(BitOpKind.And);

        public void eval_and_64u()
            => eval_scalar_binop_check<ulong>(BitOpKind.And);

        public void eval_and_128x64u()
            => eval_vec128_binop_check<ulong>(BitOpKind.And);

        public void eval_and_256x64u()
            => eval_vec256_binop_check<ulong>(BitOpKind.And);

        // ~ or

        public void eval_or_8u()
            => eval_scalar_binop_check<byte>(BitOpKind.Or);

        public void eval_or_128x8u()
            => eval_vec128_binop_check<byte>(BitOpKind.Or);

        public void eval_or_256x8u()
            => eval_vec256_binop_check<byte>(BitOpKind.Or);

        public void eval_or_32u()
            => eval_scalar_binop_check<uint>(BitOpKind.Or);

        public void eval_or_128x32u()
            => eval_vec128_binop_check<uint>(BitOpKind.Or);

        public void eval_or_256x32u()
            => eval_vec256_binop_check<uint>(BitOpKind.Or);

        public void eval_or_64u()
            => eval_scalar_binop_check<ulong>(BitOpKind.Or);

        public void eval_or_128x64u()
            => eval_vec128_binop_check<ulong>(BitOpKind.Or);

        public void eval_or_256x64u()
            => eval_vec256_binop_check<ulong>(BitOpKind.Or);

        // ~ xor

        public void eval_xor_8u()
            => eval_scalar_binop_check<byte>(BitOpKind.XOr);

        public void eval_xor_128x8u()
            => eval_vec128_binop_check<byte>(BitOpKind.XOr);

        public void eval_xor_256x8u()
            => eval_vec256_binop_check<byte>(BitOpKind.XOr);

        public void eval_xor_32u()
            => eval_scalar_binop_check<uint>(BitOpKind.XOr);

        public void eval_xor_128x32u()
            => eval_vec128_binop_check<uint>(BitOpKind.XOr);

        public void eval_xor_256x32u()
            => eval_vec256_binop_check<uint>(BitOpKind.XOr);

        public void eval_xor_64u()
            => eval_scalar_binop_check<ulong>(BitOpKind.XOr);

        public void eval_xor_128x64u()
            => eval_vec128_binop_check<ulong>(BitOpKind.XOr);

        public void eval_xor_256x64u()
            => eval_vec256_binop_check<ulong>(BitOpKind.XOr);

        // ~ sll

        public void eval_sll_8u()
            => eval_scalar_mixedop_check<byte>(BitOpKind.Sll);

        public void eval_sll_128x8u()
            => eval_vec128_mixedop_check<byte>(BitOpKind.Sll);

        public void eval_sll_256x8u()
            => eval_vec256_mixedop_check<byte>(BitOpKind.Sll);

        public void eval_sll_32u()
            => eval_scalar_mixedop_check<uint>(BitOpKind.Sll);

        public void eval_sll_128x32u()
            => eval_vec128_mixedop_check<uint>(BitOpKind.Sll);

        public void eval_sll_256x32u()
            => eval_vec256_mixedop_check<uint>(BitOpKind.Sll);

        public void eval_sll_64u()
            => eval_scalar_mixedop_check<ulong>(BitOpKind.Sll);

        public void eval_sll_128x64u()
            => eval_vec128_mixedop_check<ulong>(BitOpKind.Sll);

        public void eval_sll_256x64u()
            => eval_vec256_mixedop_check<ulong>(BitOpKind.Sll);

        // ~ srl

        public void eval_srl_8u()
            => eval_scalar_mixedop_check<byte>(BitOpKind.Srl);

        public void eval_srl_128x8u()
            => eval_vec128_mixedop_check<byte>(BitOpKind.Srl);

        public void eval_srl_256x8u()
            => eval_vec256_mixedop_check<byte>(BitOpKind.Srl);

        public void eval_srl_32u()
            => eval_scalar_mixedop_check<uint>(BitOpKind.Srl);

        public void eval_srl_128x32u()
            => eval_vec128_mixedop_check<uint>(BitOpKind.Srl);

        public void eval_srl_256x32u()
            => eval_vec256_mixedop_check<uint>(BitOpKind.Srl);

        public void eval_srl_64u()
            => eval_scalar_mixedop_check<ulong>(BitOpKind.Srl);

        public void eval_srl_128x64u()
            => eval_vec128_mixedop_check<ulong>(BitOpKind.Srl);

        public void eval_srl_256x64u()
            => eval_vec256_mixedop_check<ulong>(BitOpKind.Srl);

        // ~ rotl

        public void eval_rotl_8u()
            => eval_scalar_mixedop_check<byte>(BitOpKind.Rotl);

        public void eval_rotl_128x8u()
            => eval_vec128_mixedop_check<byte>(BitOpKind.Rotl);

        public void eval_rotl_256x8u()
            => eval_vec256_mixedop_check<byte>(BitOpKind.Rotl);

        public void eval_rotl_32u()
            => eval_scalar_mixedop_check<uint>(BitOpKind.Rotl);

        public void eval_rotl_128x32u()
            => eval_vec128_mixedop_check<uint>(BitOpKind.Rotl);

        public void eval_rotl_256x32u()
            => eval_vec256_mixedop_check<uint>(BitOpKind.Rotl);

        public void eval_rotl_64u()
            => eval_scalar_mixedop_check<ulong>(BitOpKind.Rotl);

        public void eval_rotl_128x64u()
            => eval_vec128_mixedop_check<ulong>(BitOpKind.Rotl);

        public void eval_rotl_256x64u()
            => eval_vec256_mixedop_check<ulong>(BitOpKind.Rotl);

        // ~ rotl

        public void eval_rotr_8u()
            => eval_scalar_mixedop_check<byte>(BitOpKind.Rotr);

        public void eval_rotr_128x8u()
            => eval_vec128_mixedop_check<byte>(BitOpKind.Rotr);

        public void eval_rotr_256x8u()
            => eval_vec256_mixedop_check<byte>(BitOpKind.Rotr);

        public void eval_rotr_16u()
            => eval_scalar_mixedop_check<ushort>(BitOpKind.Rotr);

        public void eval_rotr_128x16u()
            => eval_vec128_mixedop_check<ushort>(BitOpKind.Rotr);

        public void eval_rotr_256x16u()
            => eval_vec256_mixedop_check<ushort>(BitOpKind.Rotr);

        public void eval_rotr_32u()
            => eval_scalar_mixedop_check<uint>(BitOpKind.Rotr);

        public void eval_rotr_128x32u()
            => eval_vec128_mixedop_check<uint>(BitOpKind.Rotr);

        public void eval_rotr_256x32u()
            => eval_vec256_mixedop_check<uint>(BitOpKind.Rotr);

        public void eval_rotr_64u()
            => eval_scalar_mixedop_check<ulong>(BitOpKind.Rotr);

        public void eval_rotr_128x64u()
            => eval_vec128_mixedop_check<ulong>(BitOpKind.Rotr);

        public void eval_rotr_256x64u()
            => eval_vec256_mixedop_check<ulong>(BitOpKind.Rotr);


        // ~ not

        public void eval_not_8u()
            => eval_scalar_unaryop_check<byte>(BitOpKind.Not);

        public void eval_not_128x8u()
            => eval_vec128_unaryop_check<byte>(BitOpKind.Not);

        public void eval_not_256x8u()
            => eval_vec256_unaryop_check<byte>(BitOpKind.Not);

        public void eval_not_16u()
            => eval_scalar_unaryop_check<ushort>(BitOpKind.Not);

        public void eval_not_128x16u()
            => eval_vec128_unaryop_check<ushort>(BitOpKind.Not);

        public void eval_not_256x16u()
            => eval_vec256_unaryop_check<ushort>(BitOpKind.Not);

        public void eval_not_32u()
            => eval_scalar_unaryop_check<uint>(BitOpKind.Not);

        public void eval_not_128x32u()
            => eval_vec128_unaryop_check<uint>(BitOpKind.Not);

        public void eval_not_256x32u()
            => eval_vec256_unaryop_check<uint>(BitOpKind.Not);

        public void eval_not_64u()
            => eval_scalar_unaryop_check<ulong>(BitOpKind.Not);

        public void eval_not_128x64u()
            => eval_vec128_unaryop_check<ulong>(BitOpKind.Not);

        public void eval_not_256x64u()
            => eval_vec256_unaryop_check<ulong>(BitOpKind.Not);

        // ~ negate

        public void eval_negate_8u()
            => eval_scalar_unaryop_check<byte>(BitOpKind.Negate);

        public void eval_negate_128x8u()
            => eval_vec128_unaryop_check<byte>(BitOpKind.Negate);

        public void eval_negate_256x8u()
            => eval_vec256_unaryop_check<byte>(BitOpKind.Negate);

        public void eval_negate_16u()
            => eval_scalar_unaryop_check<ushort>(BitOpKind.Negate);

        public void eval_negate_128x16u()
            => eval_vec128_unaryop_check<ushort>(BitOpKind.Negate);

        public void eval_negate_256x16u()
            => eval_vec256_unaryop_check<ushort>(BitOpKind.Negate);

        public void eval_negate_32u()
            => eval_scalar_unaryop_check<uint>(BitOpKind.Negate);

        public void eval_negate_128x32u()
            => eval_vec128_unaryop_check<uint>(BitOpKind.Negate);

        public void eval_negate_256x32u()
            => eval_vec256_unaryop_check<uint>(BitOpKind.Negate);

        public void eval_negate_64u()
            => eval_scalar_unaryop_check<ulong>(BitOpKind.Negate);

        public void eval_negate_128x64u()
            => eval_vec128_unaryop_check<ulong>(BitOpKind.Negate);

        public void eval_negate_256x64u()
            => eval_vec256_unaryop_check<ulong>(BitOpKind.Negate);

        void eval_scalar_unaryop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.scalar<T>();
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                T z = e.Eval(op,x);
                switch(op)
                {
                    case BitOpKind.Not:
                        Claim.eq(gmath.flip(x), z);
                    break;
                    case BitOpKind.Negate:
                        Claim.eq(gmath.negate(x), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }
        }

        void eval_scalar_binop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.scalar<T>();
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y = Random.Next<T>();
                T z = e.Eval(op,x,y);
                switch(op)
                {
                    case BitOpKind.And:
                        Claim.eq(gmath.and(x,y), z);
                    break;
                    case BitOpKind.Or:
                        Claim.eq(gmath.or(x,y), z);
                    break;
                    case BitOpKind.XOr:
                        Claim.eq(gmath.xor(x,y), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }
        }

        void eval_scalar_mixedop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.scalar<T>();
            var minoffset = 2u;
            var maxoffset = bitsize<T>() - 2u;
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var offset = Random.Next(minoffset, maxoffset);
                T z = e.Eval(op,x,offset);
                switch(op)
                {
                    case BitOpKind.Sll:
                        Claim.eq(gmath.sll(x,(int)offset), z);
                    break;
                    case BitOpKind.Srl:
                        Claim.eq(gmath.srl(x,(int)offset), z);
                    break;
                    case BitOpKind.Rotl:
                        Claim.eq(gbits.rotl(x,offset), z);
                    break;
                    case BitOpKind.Rotr:
                        Claim.eq(gbits.rotr(x,offset), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }
        }

        void eval_vec128_mixedop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.vec128<T>();
            var minoffset = 2u;
            var maxoffset = bitsize<T>() - 2u;

            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVec128<T>();
                var offset = Random.Next(minoffset, maxoffset);
                Vec128<T> z = e.Eval(op,x, offset);
                switch(op)
                {
                    case BitOpKind.Sll:
                        Claim.eq(ginx.vsll(x,(byte)offset), z);
                    break;
                    case BitOpKind.Srl:
                        Claim.eq(ginx.vsrl(x,(byte)offset), z);
                    break;
                    case BitOpKind.Rotl:
                        Claim.eq(ginx.vrotl(x,(byte)offset), z);
                    break;
                    case BitOpKind.Rotr:
                        Claim.eq(ginx.vrotr(x,(byte)offset), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }
        }

        void eval_vec256_mixedop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.vec256<T>();
            var minoffset = 2u;
            var maxoffset = bitsize<T>() - 2u;

            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVec256<T>();
                var offset = Random.Next(minoffset, maxoffset);
                Vec256<T> z = e.Eval(op,x, offset);
                switch(op)
                {
                    case BitOpKind.Sll:
                        Claim.eq(ginx.vsll(x,(byte)offset), z);
                    break;
                    case BitOpKind.Srl:
                        Claim.eq(ginx.vsrl(x,(byte)offset), z);
                    break;
                    case BitOpKind.Rotl:
                        Claim.eq(ginx.vrotl(x,(byte)offset), z);
                    break;
                    case BitOpKind.Rotr:
                        Claim.eq(ginx.vrotr(x,(byte)offset), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }
        }



        void eval_vec128_binop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.vec128<T>();

            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVec128<T>();
                var y = Random.CpuVec128<T>();
                Vec128<T> z = e.Eval(op,x, y);
                switch(op)
                {
                    case BitOpKind.And:
                        Claim.eq(ginx.vand(x,y), z);
                    break;
                    case BitOpKind.Or:
                        Claim.eq(ginx.vor(x,y), z);
                    break;
                    case BitOpKind.XOr:
                        Claim.eq(ginx.vxor(x,y), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }
        }

        void eval_vec128_unaryop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.vec128<T>();

            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVec128<T>();
                Vec128<T> z = e.Eval(op,x);
                switch(op)
                {
                    case BitOpKind.Not:
                        Claim.eq(ginx.vflip(x), z);
                    break;
                    case BitOpKind.Negate:
                        Claim.eq(ginx.vnegate(x), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }
        }

        void eval_vec256_binop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.vec256<T>();

            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVec256<T>();
                var y = Random.CpuVec256<T>();
                Vec256<T> z = e.Eval(op,x, y);
                switch(op)
                {
                    case BitOpKind.And:
                        Claim.eq(ginx.vand(x,y), z);
                    break;
                    case BitOpKind.Or:
                        Claim.eq(ginx.vor(x,y), z);
                    break;
                    case BitOpKind.XOr:
                        Claim.eq(ginx.vxor(x,y), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }            
        
        }

        void eval_vec256_unaryop_check<T>(BitOpKind op)
            where T : unmanaged
        {
            var e = LiteralEval.vec256<T>();

            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVec256<T>();
                Vec256<T> z = e.Eval(op,x);
                switch(op)
                {
                    case BitOpKind.Not:
                        Claim.eq(ginx.vflip(x), z);
                    break;
                    case BitOpKind.Negate:
                        Claim.eq(ginx.vnegate(x), z);
                    break;
                    default:
                        Claim.fail("not implemented");
                    break;
                }
            }
        }

    }
}
