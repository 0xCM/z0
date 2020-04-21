//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Memories;
    using static Structured;

    class SFComparer<T0,T1,R> : SFMatch, ISFMatch<T0,T1,R>
        where T0 : unmanaged
        where T1 : unmanaged
        where R : unmanaged
    {
        public SFComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        void ISFMatch<T0,T1,R>.CheckMatch<F, G>(F baseline, G subject)
        {
            var casename = Identify.TestCase(Context.ValidatorType, subject);
            var succeeded = true;       
            var clock = counter();

            T0 next_x()
                => ExcludeZero ? Random.NonZ<T0>() : Random.Next<T0>();

            T1 next_y()
                => ExcludeZero ? Random.NonZ<T1>() : Random.Next<T1>();

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next_x();
                    var y = next_y();
                    CheckNumeric.eq(baseline.Invoke(x,y), subject.Invoke(x,y));
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

        void ISFMatch<T0,T1,R>.CheckSpanMatch<F, G>(F baseline, G subject)
        {
            var casename = OpUriBuilder.TestCase(Context.ValidatorType, $"{subject.Id}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var lhs = (ExcludeZero ? Random.NonZeroSpan<T0>(count) : Random.Span<T0>(count)).ReadOnly();
            ref readonly var leftIn = ref head(lhs);            
            
            var rhs = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var rightIn = ref head(rhs);
            
            var dst = Spans.alloc<R>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {                
                apply(subject, lhs, rhs, dst);
                for(var i=0; i<count; i++)
                    CheckNumeric.eq(baseline.Invoke(skip(in leftIn, i), skip(in rightIn, i)), skip(in target, i));
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
    }
}