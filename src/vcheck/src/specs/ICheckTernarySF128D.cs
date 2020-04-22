//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Vectors;

    public interface ICheckTernarySF128D<T> : ICheckSF
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVTernaryOp128DApi<T>
        {
            var t = default(T);
            var w = default(W128);
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
                        eq(f.InvokeScalar(vcell(x,j),vcell(y,j),vcell(z,j)), vcell(result,j));
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