//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Vectors;

    sealed class SVShiftValidator128D<T> : CheckOperatorSF<W128,T>, ICheckShiftSF128D<T>
        where T : unmanaged
    {
        public SVShiftValidator128D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }


    }
    
    sealed class SVShiftValidator256D<T> : CheckOperatorSF<W256,T>, ICheckShiftSF256D<T>
        where T : unmanaged
    {
        public SVShiftValidator256D(ITestContext context, bool xzero = false)
            : base(context,xzero)
        {

        }

        N256 w => default;

        void ICheckShiftSF256D<T>.CheckMatch<F>(F f)
        {
            var t = default(T);
            var cells = vcount(w,t);
            var succeeded = true;
            var casename = CaseName(f);
            var clock = counter();
            var bounds = ((byte)0, (byte)(BitSize.measure<T>() - 1));

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