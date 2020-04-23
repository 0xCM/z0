//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static Structured;

    readonly struct CheckBinaryOpSF<T> : ICheckSF<T,T,T>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckBinaryOpSF(ITestContext context, bool xzero = false)
        {
            Context = context;
            ExcludeZero = xzero;                       
        }
    }

    readonly struct CheckBinaryPredSF<T> : ICheckSF<T,T,bit>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckBinaryPredSF(ITestContext context, bool xzero = false)
        {
            Context = context;
            ExcludeZero = xzero;            
        }
    }    

    public interface ICheckSF<T0,T1,R> : ICheckSF
        where T0 : unmanaged
        where T1 : unmanaged
        where R : unmanaged
    {
        void CheckMatch<F,G>(F f, G g)
            where F : ISFuncApi<T0,T1,R>
            where G : ISFuncApi<T0,T1,R>        
        {
            var casename = Identify.TestCase(Context.HostType, g);
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
                    eq(f.Invoke(x,y), g.Invoke(x,y));
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

        void CheckSpanMatch<F,G>(F f, G g)
            where F : ISFuncApi<T0,T1,R>
            where G : ISFuncApi<T0,T1,R>
        {
            var casename = OpUriBuilder.TestCase(Context.HostType, $"{g.Id}_span");
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
                apply(g, lhs, rhs, dst);
                for(var i=0; i<count; i++)
                    eq(f.Invoke(skip(in leftIn, i), skip(in rightIn, i)), skip(in target, i));
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