//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static refs;

    class SFOpMatch<T,R> : SFMatch, ISFMatch<T,R>
        where T : unmanaged
        where R : unmanaged
    {
        public SFOpMatch(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        void ISFMatch<T,R>.MatchSpan<F, G>(F baseline, G subject)
        {
            var casename = Validity.testcase(Context.ValidatorType, subject);
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var lhs = (ExcludeZero ? Random.NonZeroSpan<T>(count) : Random.Span<T>(count)).ReadOnly();
            ref readonly var leftIn = ref head(lhs);            
            
            
            var dst = Spans.alloc<R>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {
                SFuncs.apply(subject, lhs, dst);
                for(var i=0; i<count; i++)
                    CheckNumeric.eq(baseline.Invoke(skip(in leftIn, i)), skip(in target, i));
            }
            catch(Exception e)
            {
                Error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename, succeeded, clock);
            }
        }

        void ISFMatch<T,R>.Match<F, G>(F baseline, G subject)
        {
            var casename = OpUriBuilder.TestCase(Context.ValidatorType, $"{subject.Id}_span");
            var succeeded = true;       
            var clock = counter();

            T next_x()
                => ExcludeZero ? Random.NonZ<T>() : Random.Next<T>();

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
                Context.ReportCaseResult(casename,succeeded,clock);
            }
        }
    }
}