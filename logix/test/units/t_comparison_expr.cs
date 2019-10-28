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
    using static LogicEngine;
    using CS = TypedComparisonSpec;

    public class t_comparison_expr : TypedLogixTest<t_comparison_expr>
    {
        public void scalar_lt_expr_check()
        {
            scalar_lt_expr_check<byte>();
            scalar_lt_expr_check<sbyte>();
            scalar_lt_expr_check<short>();
            scalar_lt_expr_check<ushort>();
            scalar_lt_expr_check<int>();
            scalar_lt_expr_check<uint>();
            scalar_lt_expr_check<long>();
            scalar_lt_expr_check<ulong>();
        }

        public void scalar_lteq_expr_check()
        {
            scalar_lteq_expr_check<byte>();
            scalar_lteq_expr_check<sbyte>();
            scalar_lteq_expr_check<short>();
            scalar_lteq_expr_check<ushort>();
            scalar_lteq_expr_check<int>();
            scalar_lteq_expr_check<uint>();
            scalar_lteq_expr_check<long>();
            scalar_lteq_expr_check<ulong>();
        }


        public void scalar_gt_expr_check()
        {
            scalar_gt_expr_check<byte>();
            scalar_gt_expr_check<sbyte>();
            scalar_gt_expr_check<short>();
            scalar_gt_expr_check<ushort>();
            scalar_gt_expr_check<int>();
            scalar_gt_expr_check<uint>();
            scalar_gt_expr_check<long>();
            scalar_gt_expr_check<ulong>();
        }


        public void scalar_gteq_expr_check()
        {
            scalar_gteq_expr_check<byte>();
            scalar_gteq_expr_check<sbyte>();
            scalar_gteq_expr_check<short>();
            scalar_gteq_expr_check<ushort>();
            scalar_gteq_expr_check<int>();
            scalar_gteq_expr_check<uint>();
            scalar_gteq_expr_check<long>();
            scalar_gteq_expr_check<ulong>();
        }


 
        void scalar_lt_expr_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = CS.lt(va,vb);
            for(var i=0; i<SampleSize; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x).Value;
                var expect = ScalarOpApi.eval(ComparisonKind.Lt,a,b);                
                Claim.eq(expect,result);            
            }
        }

        void scalar_lteq_expr_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = CS.lteq(va,vb);
            for(var i=0; i<SampleSize; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x).Value;
                var expect = ScalarOpApi.eval(ComparisonKind.LtEq,a,b);                
                Claim.eq(expect,result);
            }
        }

        void scalar_gt_expr_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = CS.gt(va,vb);
            for(var i=0; i<SampleSize; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var expect = ScalarOpApi.eval(ComparisonKind.Gt,a,b);   
                var actual = eval(x).Value;
                if(gmath.neq(actual,expect))             
                    Trace($"{a} > {b}?");
                Claim.eq(expect,actual);            
            }

        }

        void scalar_gteq_expr_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = CS.gteq(va,vb);
            for(var i=0; i<SampleSize; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var expect = ScalarOpApi.eval(ComparisonKind.GtEq,a,b);
                var actual = eval(x).Value;
                Claim.eq(expect,actual);
            }

        }

   }

}