//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    class TernaryValidator<T1,T2,T3,T4> : Validator, ITernaryValidator<T1,T2,T3,T4>
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {
        public TernaryValidator(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {
            
        }

        void ITernaryValidator<T1,T2,T3,T4>.CheckMatch<F, G>(F baseline, G subject)
        {
            var casename = Context.CaseName(subject);
            var succeeded = true;       
            var clock = counter();

            T1 next_x()
                => ExcludeZero ? Random.NonZero<T1>() : Random.Next<T1>();

            T2 next_y()
                => ExcludeZero ? Random.NonZero<T2>() : Random.Next<T2>();

            T3 next_z()
                => ExcludeZero ? Random.NonZero<T3>() : Random.Next<T3>();

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
                errout(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,clock);
            }
        }

        void ITernaryValidator<T1,T2,T3,T4>.CheckSpan<F, G>(F baseline, G subject)
        {
            var casename = Context.CaseName($"{subject.Id}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var inA = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var inATarget = ref head(inA);            
            
            var inB = (ExcludeZero ? Random.NonZeroSpan<T2>(count) : Random.Span<T2>(count)).ReadOnly();
            ref readonly var inBTarget = ref head(inB);

            var inC = (ExcludeZero ? Random.NonZeroSpan<T3>(count) : Random.Span<T3>(count)).ReadOnly();
            ref readonly var inCTarget = ref head(inC);

            var dst = span<T4>(count);
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
                errout(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename, succeeded, clock);
            }
        }
    }
}