//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    static class Validators
    {
        public static IBinaryValidator<T,T,T> BinaryValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
            => new BinaryValidator<T,T,T>(context);

        public static IUnaryValidator<T,T> UnaryValidator<T>(this ITestContext context, T t = default)
            where T : unmanaged
                => new UnaryValidator<T,T>(context);

    }

    
    public interface IBinaryValidator<T1,T2,T3>
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>;        
    }

    public interface IUnaryValidator<T1,T2>
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : IUnaryFunc<T1,T2>
            where G : IUnaryFunc<T1,T2>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : IUnaryFunc<T1,T2>
            where G : IUnaryFunc<T1,T2>;        
    }

    abstract class Validator
    {
        protected Validator(ITestContext context)
        {
            this.Context = context;
            this.ExcludeZero = false;
        }
        
        protected ITestContext Context {get;}

        protected IPolyrand Random
            => Context.Random;

        public int RepCount
            => Context.RepCount;

        protected bool ExcludeZero {get;}
    }

    class BinaryValidator<T1,T2,T3> : Validator, IBinaryValidator<T1,T2,T3>
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {
        public BinaryValidator(ITestContext context)
            : base(context)
        {
            
        }

        void IBinaryValidator<T1,T2,T3>.CheckMatch<F, G>(F baseline, G subject)
        {
            var casename = Context.CaseName(subject);
            var succeeded = true;       
            var clock = counter();

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Next<T1>();
                    var y = Random.Next<T2>();
                    Claim.eq(baseline.Invoke(x,y), subject.Invoke(x,y));
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

        void IBinaryValidator<T1,T2,T3>.CheckSpan<F, G>(F baseline, G subject)
        {
            var casename = Context.CaseName($"{subject.Moniker}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var lhs = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var leftIn = ref head(lhs);            
            
            var rhs = (ExcludeZero ? Random.NonZeroSpan<T2>(count) : Random.Span<T2>(count)).ReadOnly();
            ref readonly var rightIn = ref head(rhs);
            
            var dst = span<T3>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {                
                BinaryFunc.apply(subject, lhs, rhs, dst);
                for(var i=0; i<count; i++)
                    Claim.numeq(baseline.Invoke(skip(in leftIn, i), skip(in rightIn, i)), skip(in target, i));
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

    }

    sealed class UnaryValidator<T1,T2> : Validator, IUnaryValidator<T1,T2>
        where T1 : unmanaged
        where T2 : unmanaged
    {
        public UnaryValidator(ITestContext context)
            : base(context)
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

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.Next<T1>();
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
