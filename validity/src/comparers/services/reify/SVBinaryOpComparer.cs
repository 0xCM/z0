//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Validity;
    using static vgeneric;

    sealed class SVBinaryOp128DApiComparer<T> : OperatorComparer<W128,T>, ISVBinaryOpMatch128D<T>
        where T : unmanaged
    {
        public SVBinaryOp128DApiComparer(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N128 w => default;

        void ISVBinaryOpMatch128D<T>.CheckMatch<F>(F f)
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
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Claim.numeq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
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

    sealed class VBinaryValidator256D<T> : OperatorComparer<W256,T>,  ISVBinaryOpMatch256D<T>
        where T : unmanaged
    {
        public VBinaryValidator256D(IValidationContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N256 w => default;

        void ISVBinaryOpMatch256D<T>.CheckMatch<F>(F f)
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
                    var z = f.Invoke(x,y);
                    for(var j=0; j< cells; j++)
                        Claim.numeq(f.InvokeScalar(vcell(x,j),vcell(y,j)), vcell(z,j));
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