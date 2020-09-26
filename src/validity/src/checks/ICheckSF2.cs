//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static SFx;

    public readonly struct CheckBinaryOpSF<T> : ICheckSF<T,T,T>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckBinaryOpSF(ITestContext context, bool xz = false)
        {
            Context = context;
            ExcludeZero = xz;
        }
    }

    public readonly struct CheckBinaryPredSF<T> : ICheckSF<T,T,bit>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckBinaryPredSF(ITestContext context, bool xz = false)
        {
            Context = context;
            ExcludeZero = xz;
        }
    }

    public readonly struct CheckBinaryPredSF8<T> : ICheckSF<T,T,bool>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}

        [MethodImpl(Inline)]
        public CheckBinaryPredSF8(ITestContext context, bool xz = false)
        {
            Context = context;
            ExcludeZero = xz;
        }
    }

    public interface ICheckSF<T0,T1,R> : ICheckSF
        where T0 : unmanaged
        where T1 : unmanaged
        where R : unmanaged
    {
        void CheckMatch<F,G>(F f, G g)
            where F : IFunc<T0,T1,R>
            where G : IFunc<T0,T1,R>
        {
            var casename = ApiUri.TestCase(Context.HostType, g);
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
                    Eq(f.Invoke(x,y), g.Invoke(x,y));
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
            where F : IFunc<T0,T1,R>
            where G : IFunc<T0,T1,R>
        {
            var casename = ApiUri.TestCase(Context.HostType, $"{g.Id}_span");
            var succeeded = true;
            var count = RepCount;
            var clock = counter();

            var lhs = (ExcludeZero ? Random.NonZeroSpan<T0>(count) : Random.Span<T0>(count)).ReadOnly();
            ref readonly var leftIn = ref z.first(lhs);

            var rhs = (ExcludeZero ? Random.NonZeroSpan<T1>(count) : Random.Span<T1>(count)).ReadOnly();
            ref readonly var rightIn = ref z.first(rhs);

            var dst = z.span<R>(count);
            ref var target = ref z.first(dst);

            clock.Start();

            try
            {
                apply(g, lhs, rhs, dst);
                for(var i=0u; i<count; i++)
                    Eq(f.Invoke(z.skip(leftIn, i), z.skip(rightIn, i)), z.skip(target, i));
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