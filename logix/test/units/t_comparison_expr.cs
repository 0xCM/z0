//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

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
  }
}