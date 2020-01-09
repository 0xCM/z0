//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static zfunc;

    sealed class UnaryValidator<T1,T2> : Validator, IUnaryValidator<T1,T2>
        where T1 : unmanaged
        where T2 : unmanaged
    {
        public UnaryValidator(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        void IUnaryValidator<T1,T2>.CheckSpan<F, G>(F baseline, G subject)
        {
            var casename = Context.CaseName($"{subject.Moniker}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var lhs = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var leftIn = ref head(lhs);            
            
            
            var dst = span<T2>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {
                UnaryFunc.apply(subject, lhs, dst);
                for(var i=0; i<count; i++)
                    Claim.numeq(baseline.Invoke(skip(in leftIn, i)), skip(in target, i));
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename, succeeded, clock);
            }
        }

        void IUnaryValidator<T1,T2>.CheckMatch<F, G>(F baseline, G subject)
        {
            var casename = Context.CaseName(subject);
            var succeeded = true;       
            var clock = counter();

            T1 next_x()
                => ExcludeZero ? Random.NonZero<T1>() : Random.Next<T1>();

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
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,clock);
            }
        }
    }
}