//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using static Structured;

    readonly struct CheckTernaryOpSF<T> : ICheckSF<T,T,T,T>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckTernaryOpSF(ITestContext context, bool xzero = false)
        {
            Context = context;
            ExcludeZero = xzero;                                   
        }
    }

    readonly struct CheckTernaryPredSF<T> : ICheckSF<T,T,T,bit>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckTernaryPredSF(ITestContext context, bool xzero = false)
        {
            Context = context;
            ExcludeZero = xzero;            
        }
    }    

    public interface ICheckSF<T0,T1,T2,R> : ICheckSF
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where R : unmanaged
    {
        void CheckMatch<F,G>(F f, G g)
            where F : IFunc<T0,T1,T2,R>
            where G : IFunc<T0,T1,T2,R>
        {
            var casename = Identify.TestCase(Context.HostType, g);
            var succeeded = true;       
            var clock = counter();

            T0 next_x()
                => ExcludeZero ? Random.NonZ<T0>() : Random.Next<T0>();

            T1 next_y()
                => ExcludeZero ? Random.NonZ<T1>() : Random.Next<T1>();

            T2 next_z()
                => ExcludeZero ? Random.NonZ<T2>() : Random.Next<T2>();

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = next_x();
                    var y = next_y();
                    var z = next_z();
                    Eq(f.Invoke(x,y,z), g.Invoke(x,y,z));
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
            where F : IFunc<T0,T1,T2,R>
            where G : IFunc<T0,T1,T2,R>        
        {
            var casename = OpUriBuilder.TestCase(Context.HostType, $"{g.Id}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var inA = (ExcludeZero ? Random.NonZeroSpan<T0>(count) : Random.Span<T0>(count)).ReadOnly();
            ref readonly var inATarget = ref head(inA);            
            
            var inB = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var inBTarget = ref head(inB);

            var inC = (ExcludeZero ? Random.NonZeroSpan<T2>(count) : Random.Span<T2>(count)).ReadOnly();
            ref readonly var inCTarget = ref head(inC);

            var dst = Spans.alloc<R>(count);
            ref var target = ref head(dst);
            
            clock.Start();
            try
            {                
                apply(g, inA, inB, inC, dst);
                for(var i=0; i<count; i++)
                    Eq(f.Invoke(skip(in inATarget, i), skip(in inBTarget, i), skip(in inCTarget, i)), skip(in target, i));
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