//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static Validity;

    class BinaryFuncComparer<T1,T2,T3> : FunctionComparer, IBinaryFuncComparer<T1,T2,T3>
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        public BinaryFuncComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        public BinaryFuncComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        void IBinaryFuncComparer<T1,T2,T3>.CheckMatch<F, G>(F baseline, G subject)
        {
            var casename = TestIdentity.testcase(Context.HostType, subject);
            var succeeded = true;       
            var clock = counter();

            T1 next_x()
                => ExcludeZero ? Random.NonZ<T1>() : Random.Next<T1>();

            T2 next_y()
                => ExcludeZero ? Random.NonZ<T2>() : Random.Next<T2>();

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next_x();
                    var y = next_y();
                    Claim.eq(baseline.Invoke(x,y), subject.Invoke(x,y));
                }
            }
            catch(Exception e)
            {
                Error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,clock);
            }
        }

        void IBinaryFuncComparer<T1,T2,T3>.CheckSpan<F, G>(F baseline, G subject)
        {
            var casename = TestIdentity.testcase(Context.HostType, $"{subject.Id}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var lhs = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var leftIn = ref head(lhs);            
            
            var rhs = (ExcludeZero ? Random.NonZeroSpan<T2>(count) : Random.Span<T2>(count)).ReadOnly();
            ref readonly var rightIn = ref head(rhs);
            
            var dst = alloc<T3>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {                
                SpanFunc.apply(subject, lhs, rhs, dst);
                for(var i=0; i<count; i++)
                    Claim.numeq(baseline.Invoke(skip(in leftIn, i), skip(in rightIn, i)), skip(in target, i));
            }
            catch(Exception e)
            {
                Error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename, succeeded, clock);
            }
        }
    }
}