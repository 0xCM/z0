//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Root;
    using static Validity;

    class UnaryFuncComparer<T1,T2> : FunctionComparer, ISFApiComparer<T1,T2>
        where T1 : unmanaged
        where T2 : unmanaged
    {
        public UnaryFuncComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        public UnaryFuncComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        void ISFApiComparer<T1,T2>.CheckSpan<F, G>(F baseline, G subject)
        {
            var casename = TestIdentity.testcase(Context.HostType, subject);
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var lhs = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var leftIn = ref head(lhs);            
            
            
            var dst = alloc<T2>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {
                SpanFunc.apply(subject, lhs, dst);
                for(var i=0; i<count; i++)
                    Claim.numeq(baseline.Invoke(skip(in leftIn, i)), skip(in target, i));
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

        void ISFApiComparer<T1,T2>.CheckMatch<F, G>(F baseline, G subject)
        {
            var casename = TestIdentity.testcase(Context.HostType, $"{subject.Id}_span");
            var succeeded = true;       
            var clock = counter();

            T1 next_x()
                => ExcludeZero ? Random.NonZ<T1>() : Random.Next<T1>();

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next_x();
                    Claim.eq(baseline.Invoke(x), subject.Invoke(x));
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
    }
}