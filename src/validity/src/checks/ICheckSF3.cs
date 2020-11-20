//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static SFx;

    public readonly struct CheckTernaryOpSF<T> : ICheckSF<T,T,T,T>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckTernaryOpSF(ITestContext context, bool xz = false)
        {
            Context = context;
            ExcludeZero = xz;
        }
    }

    public readonly struct CheckTernaryPredSF<T> : ICheckSF<T,T,T,Bit32>
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
            var casename = ApiUri.TestCase(Context.HostType, g);
            var succeeded = true;
            var clock = Time.counter(false);

            T0 next_x()
                => ExcludeZero ? Random.NonZ<T0>() : Random.Next<T0>();

            T1 next_y()
                => ExcludeZero ? Random.NonZ<T1>() : Random.Next<T1>();

            T2 next_z()
                => ExcludeZero ? Random.NonZ<T2>() : Random.Next<T2>();

            clock.Start();

            try
            {
                for(var i=0u; i<RepCount; i++)
                {
                    var x = next_x();
                    var y = next_y();
                    var z = next_z();
                    eq(f.Invoke(x,y,z), g.Invoke(x,y,z));
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
            var casename = ApiUri.TestCase(Context.HostType, $"{g.Id}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = Time.counter(false);

            var inA = (ExcludeZero ? Random.NonZeroSpan<T0>(count) : Random.Span<T0>(count)).ReadOnly();
            ref readonly var inATarget = ref first(inA);

            var inB = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var inBTarget = ref first(inB);

            var inC = (ExcludeZero ? Random.NonZeroSpan<T2>(count) : Random.Span<T2>(count)).ReadOnly();
            ref readonly var inCTarget = ref first(inC);

            var dst = Spans.alloc<R>(count);
            ref var target = ref first(dst);

            clock.Start();

            try
            {
                apply(g, inA, inB, inC, dst);
                for(var i=0u; i<count; i++)
                    eq(f.Invoke(skip(inATarget, i), skip(inBTarget, i), skip(inCTarget, i)), skip(target, i));
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