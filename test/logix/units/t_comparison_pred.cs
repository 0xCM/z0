//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;

    using static LogicEngine;
    using static PredicateSpec;
    using static BinaryComparisonApiKeyKind;
    using static NumericLogixHost;
    using static BitLogix;

    public class t_comparison_pred : TypedLogixTest<t_comparison_pred>
    {
        public void trichotomy_check()
        {
            trichotomy_check<uint>();

        }

        public void eq_pred_check()
        {
            var kind = Eq;
            predicate_check<sbyte>(kind);
            predicate_check<byte>(kind);
            predicate_check<short>(kind);
            predicate_check<ushort>(kind);
            predicate_check<int>(kind);
            predicate_check<uint>(kind);
            predicate_check<long>(kind);
            predicate_check<ulong>(kind);
        }

        public void neq_pred_check()
        {
            var kind = Eq;
            predicate_check<sbyte>(kind);
            predicate_check<byte>(kind);
            predicate_check<short>(kind);
            predicate_check<ushort>(kind);
            predicate_check<int>(kind);
            predicate_check<uint>(kind);
            predicate_check<long>(kind);
            predicate_check<ulong>(kind);
        }

        public void lt_pred_check()
        {
            var kind = Lt;
            predicate_check<sbyte>(kind);
            predicate_check<byte>(kind);
            predicate_check<short>(kind);
            predicate_check<ushort>(kind);
            predicate_check<int>(kind);
            predicate_check<uint>(kind);
            predicate_check<long>(kind);
            predicate_check<ulong>(kind);
        }

        public void lteq_pred_check()
        {
            var kind = LtEq;
            predicate_check<sbyte>(kind);
            predicate_check<byte>(kind);
            predicate_check<short>(kind);
            predicate_check<ushort>(kind);
            predicate_check<int>(kind);
            predicate_check<uint>(kind);
            predicate_check<long>(kind);
            predicate_check<ulong>(kind);
        }

        public void gt_pred_check()
        {
            var kind = Gt;
            predicate_check<sbyte>(kind);
            predicate_check<byte>(kind);
            predicate_check<short>(kind);
            predicate_check<ushort>(kind);
            predicate_check<int>(kind);
            predicate_check<uint>(kind);
            predicate_check<long>(kind);
            predicate_check<ulong>(kind);
        }

        public void gteq_pred_check()
        {
            var kind = GtEq;
            predicate_check<sbyte>(kind);
            predicate_check<byte>(kind);
            predicate_check<short>(kind);
            predicate_check<ushort>(kind);
            predicate_check<int>(kind);
            predicate_check<uint>(kind);
            predicate_check<long>(kind);
            predicate_check<ulong>(kind);
        }

        void trichotomy_check<T>()
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var vc = var_c<T>();
            var x = compare(BinaryComparisonApiKeyKind.Lt,va,vb);
            var y = compare(BinaryComparisonApiKeyKind.Lt,vb,vc);
            var z = compare(BinaryComparisonApiKeyKind.Lt,vc,va);
            for(var i=0; i<RepCount; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var c = vc.Set(Random);

                var ab = gmath.lt(a,b);
                var abx = eval(x);
                Claim.Require(ab == abx);

                var bc = gmath.lt(b,c);
                var bcy = eval(y);
                Claim.Require(bc == bcy);

                var ca = gmath.lt(c,a);
                var caz = eval(z);
                Claim.Require(ca == caz);
            }

        }

        void predicate_check<T>(BinaryComparisonApiKeyKind kind)
            where T : unmanaged
        {
            var va = var_a<T>();
            var vb = var_b<T>();
            var x = compare(kind,va,vb);
            for(var i=0; i<RepCount; i++)
            {
                var a = va.Set(Random);
                var b = vb.Set(Random);
                var result = eval(x);
                var expect = NumericLogixHost.eval(kind,a,b);
                Claim.Eq(expect,result);
            }
        }
    }
}