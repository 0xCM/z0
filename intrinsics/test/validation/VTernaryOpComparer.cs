//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static vgeneric;

    sealed class VTernaryValidator128D<T> : FuncComparer, IVTernaryOpComparer128D<T>
        where T : unmanaged
    {
        public VTernaryValidator128D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N128 w => default;

        void IVTernaryOpComparer128D<T>.CheckScalarMatch<F>(F f)
        {
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = Context.CaseName(f);
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
                        Claim.numeq(f.InvokeScalar(vcell(x,j),vcell(y,j),vcell(z,j)), vcell(result,j));
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

    sealed class VTernaryValidator256D<T> : FuncComparer, IVTernaryOpComparer256D<T>
        where T : unmanaged
    {
        public VTernaryValidator256D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N256 w => default;

        void IVTernaryOpComparer256D<T>.CheckScalarMatch<F>(F f)
        {
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = Context.CaseName(f);
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
                        Claim.numeq(f.InvokeScalar(vcell(x,j),vcell(y,j),vcell(z,j)), vcell(result,j));
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