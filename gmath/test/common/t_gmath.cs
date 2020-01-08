//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public abstract class t_gmath<X> : UnitTest<X>    
        where X : t_gmath<X>, new()
    {
        protected void CheckUnaryFuncSpan<F,G,T1,T2>(F baseline, G subject, T1 t1 = default, T2 t2 = default, bool xzero = false,  SystemCounter clock = default)
            where T1 : unmanaged
            where T2 : unmanaged
            where F : IUnaryFunc<T1,T2>
            where G : IUnaryFunc<T1,T2>
        {
            var casename = CaseName($"{subject.Moniker}_span");
            var succeeded = true;
            var count = RepCount;

            var src = (xzero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var input = ref head(src);            
            
            var dst = span<T2>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {                
                UnaryFunc.apply(subject, src, dst);
                for(var i=0; i<count; i++)
                    Claim.numeq(baseline.Invoke(skip(in input, i)), skip(in target, i));
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename, succeeded, clock);
            }
        }

        protected void CheckUnaryOpSpan<F,G,T>(F baseline, G subject, T t = default, bool xzero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IUnaryOp<T>
            where G : IUnaryOp<T>
                => CheckUnaryFuncSpan(baseline, subject,t,t,xzero,clock);

        protected void CheckBinFuncSpan<F,G,T1,T2,T3>(F baseline, G subject, T1 t1 = default, T2 t2 = default, T3 t3 = default, bool xzero = false,  SystemCounter clock = default)
            where T1 : unmanaged
            where T2 : unmanaged
            where T3 : unmanaged
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>
        {
            var casename = CaseName($"{subject.Moniker}_span");
            var succeeded = true;
            var count = RepCount;

            var lhs = (xzero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var leftIn = ref head(lhs);            
            
            var rhs = (xzero ? Random.NonZeroSpan<T2>(count) : Random.Span<T2>(count)).ReadOnly();
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
                ReportOutcome(casename, succeeded, clock);
            }
        }

        protected void CheckBinOpSpan<F,G,T>(F baseline, G subject, T t = default, bool xzero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IBinaryOp<T>
            where G : IBinaryOp<T>
                => CheckBinFuncSpan(baseline, subject, t, t, t, xzero, clock);

        protected void CheckBinPredSpan<F,G,T>(F baseline, G subject, T t = default, bool xzero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IBinaryPred<T>
            where G : IBinaryPred<T>
                => CheckBinFuncSpan(baseline, subject, t, t, bit.Off, xzero, clock);

        protected void CheckBinPredMatch<F,G,T>(F baseline, G subject, T t = default, SystemCounter clock = default)
            where T : unmanaged
            where F : IBinaryPred<T>
            where G : IBinaryPred<T>
        {
            var casename = CaseName(subject);
            var succeeded = true;
            
            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    (var x, var y) = Random.NextPair<T>();                    
                    Claim.numeq(baseline.Invoke(x,y), subject.Invoke(x,y));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
            }
        }

        protected void CheckUnaryOpMatch<F,G,T>(F baseline, G subject, T t = default, bool xzero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IUnaryOp<T>
            where G : IUnaryOp<T>
        {
            var casename = CaseName(subject);
            var succeeded = true;
            var next = xzero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next();
                    Claim.numeq(baseline.Invoke(x), subject.Invoke(x));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename, succeeded, clock);
            }
        }

        protected void CheckBinOpMatch<F,G,T>(F baseline, G subject, T t = default, bool xzero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : IBinaryOp<T>
            where G : IBinaryOp<T>
        {
            var casename = CaseName(subject);
            var succeeded = true;
            var next = xzero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next();
                    var y = next();
                    Claim.numeq(baseline.Invoke(x,y), subject.Invoke(x,y));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
            }
        }

        protected void CheckTernaryOpMatch<F,G,T>(F baseline, G subject, T t = default, bool xzero = false,  SystemCounter clock = default)
            where T : unmanaged
            where F : ITernaryOp<T>
            where G : ITernaryOp<T>
        {
            var casename = CaseName(subject);
            var succeeded = true;
            var next = xzero ? new Func<T>(Random.NonZero<T>) : new Func<T>(Random.Next<T>);
            
            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next();
                    var y = next();
                    var z = next();
                    Claim.numeq(baseline.Invoke(x,y,z), subject.Invoke(x,y,z));
                }
            }
            catch(Exception e)
            {
                error(e, casename);
                succeeded = false;
            }
            finally
            {
                ReportOutcome(casename,succeeded,clock);
            }
        }
    }
}
