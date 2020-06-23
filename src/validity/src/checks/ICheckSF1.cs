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

    readonly struct CheckUnaryOpSF<T> : ICheckSF<T,T>
        where T : unmanaged
    {
        public ITestContext Context {get;}

        public bool ExcludeZero {get;}
        
        [MethodImpl(Inline)]
        public CheckUnaryOpSF(ITestContext context, bool xzero = false)
        {
            Context = context;
            ExcludeZero = xzero;           
        }
    }

    public interface ICheckSF<T,R> : ICheckSF
        where T : unmanaged
        where R : unmanaged
    {
        void CheckMatch<F,G>(F f, G g)
            where F : IFunc<T,R>
            where G : IFunc<T,R>
        {
            var casename = OpUriBuilder.TestCase(Context.HostType, $"{g.Id}_span");
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
                    Eq(f.Invoke(x), g.Invoke(x));
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
            where F : IFunc<T,R>
            where G : IFunc<T,R>
        {
            var casename = Identify.TestCase(Context.HostType, g);
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
                    Eq(f.Invoke(skip(in leftIn, i)), skip(in target, i));
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