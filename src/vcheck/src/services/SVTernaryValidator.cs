//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Vectors;

    public readonly struct SVTernaryValidator128D<T> : ICheckTernarySF128D<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static ICheckTernarySF128D<T> Create(ITestContext context)
            => new SVTernaryValidator128D<T>(context);

        [MethodImpl(Inline)]
        SVTernaryValidator128D(ITestContext context)        
        {
            this.Context = context;
        }

        public ITestContext Context {get;}
    }

    // sealed class SVTernaryValidator128D<T> : OperatorComparer<W128,T>, ISVTernaryOpMatch128D<T>
    //     where T : unmanaged
    // {
    //     public SVTernaryValidator128D(ITestContext context, bool xzero = false)
    //         : base(context,xzero)
    //     {

    //     }

    //     N128 w => default;

    //     void ISVTernaryOpMatch128D<T>.CheckMatch<F>(F f)
    //     {
    //         var t = default(T);
    //         var cells = vcount(w,t);
    //         var succeeded = true;
    //         var casename = CaseName(f);
    //         var clock = counter();

    //         clock.Start();
    //         try
    //         {
    //             for(var i=0; i<RepCount; i++)
    //             {
    //                 var x = Random.CpuVector(w,t);
    //                 var y = Random.CpuVector(w,t);
    //                 var z = Random.CpuVector(w,t);
    //                 var result = f.Invoke(x,y,z);
    //                 for(var j=0; j< cells; j++)
    //                     Claim.eq(f.InvokeScalar(vcell(x,j),vcell(y,j),vcell(z,j)), vcell(result,j));
    //             }
    //         }
    //         catch(Exception e)
    //         {
    //             term.errlabel(e, casename);
    //             succeeded = false;
    //         }
    //         finally
    //         {
    //             Context.ReportCaseResult(casename,succeeded,clock);
    //         }
    //     }
    // }

    sealed class SVTernaryValidator256D<T> : CheckOperatorSF<W256,T>, ISVTernaryOpMatch256D<T>
        where T : unmanaged
    {
        public SVTernaryValidator256D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N256 w => default;

        void ISVTernaryOpMatch256D<T>.CheckMatch<F>(F f)
        {
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);
            var clock = counter();

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var y = Random.CpuVector(w,t);
                    var z = Random.CpuVector(w,t);
                    var result = f.Invoke(x,y,z);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j),vcell(y,j),vcell(z,j)), vcell(result,j));
                }
            }
            catch(Exception e)
            {
                term.errlabel(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportCaseResult(casename,succeeded,clock);
            }
        }
    }
}