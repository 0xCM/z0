//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Validity;
    using static vgeneric;

    sealed class VUnaryValidator128D<T> : OperatorComparer<W128,T>, IVUnaryOpComparer128D<T>
        where T : unmanaged
    {
        public VUnaryValidator128D(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N128 w => default;

        void IVUnaryOpComparer128D<T>.CheckScalarMatch<F>(F f)
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
                        Claim.numeq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                term.error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,clock);
            }
        }
    }
    
    sealed class VUnaryValidator256D<T> : OperatorComparer<W256,T>, IVUnaryOpComparer256D<T>
        where T : unmanaged
    {
        public VUnaryValidator256D(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N256 w => default;

        void IVUnaryOpComparer256D<T>.CheckScalarMatch<F>(F f)
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
                        Claim.numeq(f.InvokeScalar(vcell(x,j)), vcell(z,j));
                }
            }
            catch(Exception e)
            {
                term.error(e, casename);
                succeeded = false;
            }
            finally
            {
                Context.ReportOutcome(casename,succeeded,clock);
            }
        }
    }
}