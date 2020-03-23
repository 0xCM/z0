//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static Validity;

    class TernaryFuncComparer<T1,T2,T3,T4> : FunctionComparer, ITernaryFuncComparer<T1,T2,T3,T4>
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        public TernaryFuncComparer(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        public TernaryFuncComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        void ITernaryFuncComparer<T1,T2,T3,T4>.CheckMatch<F, G>(F baseline, G subject)
        {
            var casename = TestIdentity.testcase(Context.HostType, subject);
            var succeeded = true;       
            var clock = counter();

            T1 next_x()
                => ExcludeZero ? Random.NonZ<T1>() : Random.Next<T1>();

            T2 next_y()
                => ExcludeZero ? Random.NonZ<T2>() : Random.Next<T2>();

            T3 next_z()
                => ExcludeZero ? Random.NonZ<T3>() : Random.Next<T3>();

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next_x();
                    var y = next_y();
                    var z = next_z();
                    Claim.eq(baseline.Invoke(x,y,z), subject.Invoke(x,y,z));
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

        void ITernaryFuncComparer<T1,T2,T3,T4>.CheckSpan<F, G>(F baseline, G subject)
        {
            var casename = TestIdentity.testcase(Context.HostType, $"{subject.Id}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var inA = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var inATarget = ref head(inA);            
            
            var inB = (ExcludeZero ? Random.NonZeroSpan<T2>(count) : Random.Span<T2>(count)).ReadOnly();
            ref readonly var inBTarget = ref head(inB);

            var inC = (ExcludeZero ? Random.NonZeroSpan<T3>(count) : Random.Span<T3>(count)).ReadOnly();
            ref readonly var inCTarget = ref head(inC);

            var dst = alloc<T4>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {                
                SpanFunc.apply(subject, inA, inB, inC, dst);
                for(var i=0; i<count; i++)
                    Claim.numeq(baseline.Invoke(skip(in inATarget, i), skip(in inBTarget, i), skip(in inCTarget, i)), skip(in target, i));
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