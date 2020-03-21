//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;
    using static vgeneric;

    sealed class VShiftComparer128D<T> : FuncComparer, IVShiftOpComparer128D<T>
        where T : unmanaged
    {
        public VShiftComparer128D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N128 w => default;

        void IVShiftOpComparer128D<T>.CheckScalarMatch<F>(F f)
        {
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = Context.CaseName(f);
            var clock = counter();
            var bounds = ((byte)0, (byte)(bitsize(t) - 1));

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
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
    
    sealed class VShiftValidator256D<T> : FuncComparer, IVShiftOpComparer256D<T>
        where T : unmanaged
    {
        public VShiftValidator256D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N256 w => default;

        void IVShiftOpComparer256D<T>.CheckScalarMatch<F>(F f)
        {
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = Context.CaseName(f);
            var clock = counter();
            var bounds = ((byte)0, (byte)(bitsize(t) - 1));

            clock.Start();
            try
            {
                for(var i=0; i<RepCount; i++)
                {
                    var x = Random.CpuVector(w,t);
                    var offset = Random.Next<byte>(bounds);
                    var z = f.Invoke(x,offset);
                    for(var j=0; j< cells; j++)
                        Claim.eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
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