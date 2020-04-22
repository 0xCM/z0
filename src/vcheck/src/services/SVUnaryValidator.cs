//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Vectors;

    sealed class SVUnaryValidator128D<T> : CheckOperatorSF<W128,T>, ICheckUnarySF128D<T>
        where T : unmanaged
    {
        public SVUnaryValidator128D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N128 w => default;

        void ICheckUnarySF128D<T>.CheckMatch<F>(F f)
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
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
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
    
    sealed class SVUnaryValidator256D<T> : CheckOperatorSF<W256,T>, ICheckUnarySF256D<T>
        where T : unmanaged
    {

        public SVUnaryValidator256D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N256 w => default;

        void ICheckUnarySF256D<T>.CheckMatch<F>(F f)
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
                    var z = f.Invoke(x);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
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