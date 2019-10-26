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
    
    using static zfunc;
    using static ArithmeticSpec;
    using static TypedLogicSpec;

    using static LogicEngine;

    public class t_arithmetic_expr : TypedLogixTest<t_arithmetic_expr>
    {

        public void scalar_lt_check()
        {
            scalar_lt_check<byte>();
            scalar_lt_check<sbyte>();
            scalar_lt_check<short>();
            scalar_lt_check<ushort>();
            scalar_lt_check<int>();
            scalar_lt_check<uint>();
            scalar_lt_check<long>();
            scalar_lt_check<ulong>();
        }


        public void scalar_lteq_check()
        {
            scalar_lteq_check<byte>();
            scalar_lteq_check<sbyte>();
            scalar_lteq_check<short>();
            scalar_lteq_check<ushort>();
            scalar_lteq_check<int>();
            scalar_lteq_check<uint>();
            scalar_lteq_check<long>();
            scalar_lteq_check<ulong>();
        }


        public void scalar_gt_check()
        {
            scalar_gt_check<byte>();
            scalar_gt_check<sbyte>();
            scalar_gt_check<short>();
            scalar_gt_check<ushort>();
            scalar_gt_check<int>();
            scalar_gt_check<uint>();
            scalar_gt_check<long>();
            scalar_gt_check<ulong>();
        }


        public void scalar_gteq_check()
        {
            scalar_gteq_check<byte>();
            scalar_gteq_check<sbyte>();
            scalar_gteq_check<short>();
            scalar_gteq_check<ushort>();
            scalar_gteq_check<int>();
            scalar_gteq_check<uint>();
            scalar_gteq_check<long>();
            scalar_gteq_check<ulong>();
        }


        void scalar_lt_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = lt(va,vb);
            for(var i=0; i<SampleSize; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x).Value.ToBit();
                var expect = ScalarOpApi.eval(ComparisonOpKind.Lt,a,b);                
                Claim.eq(expect,(bit)gmath.lt(a,b));
                Claim.eq(expect,result);
            }

        }

        void scalar_lteq_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = lteq(va,vb);
            for(var i=0; i<SampleSize; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x).Value.ToBit();
                var expect = ScalarOpApi.eval(ComparisonOpKind.LtEq,a,b);                
                Claim.eq(expect,(bit)gmath.lteq(a,b));
                Claim.eq(expect,result);
            }
        }

        void scalar_gt_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = gt(va,vb);
            for(var i=0; i<SampleSize; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x).Value.ToBit();
                var expect = ScalarOpApi.eval(ComparisonOpKind.Gt,a,b);                
                Claim.eq(expect,(bit)gmath.gt(a,b));
                Claim.eq(expect,result);
            }

        }

        void scalar_gteq_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = gteq(va,vb);
            for(var i=0; i<SampleSize; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x).Value.ToBit();
                var expect = ScalarOpApi.eval(ComparisonOpKind.GtEq,a,b);                
                Claim.eq(expect,(bit)gmath.gteq(a,b));
                Claim.eq(expect,result);
            }

        }

    }

}