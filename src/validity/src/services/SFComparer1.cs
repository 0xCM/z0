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

    class SFOpMatch<T,R> : SFMatch, ISFMatch<T,R>
        where T : unmanaged
        where R : unmanaged
    {
        public SFOpMatch(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        void ISFMatch<T,R>.CheckSpanMatch<F, G>(F f, G g)
        {
            var casename = Identities.TestCase(Context.ValidatorType, g);
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
                apply(g, lhs, dst);
                for(var i=0; i<count; i++)
                    CheckNumeric.eq(f.Invoke(skip(in leftIn, i)), skip(in target, i));
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

        void ISFMatch<T,R>.CheckMatch<F, G>(F f, G g)
        {
            var casename = OpUriBuilder.TestCase(Context.ValidatorType, $"{g.Id}_span");
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
                    CheckNumeric.eq(f.Invoke(x), g.Invoke(x));
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