//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;
    using static Memories;
    
    public interface ICheckShiftSF128D<T> : ICheckSF
        where T : unmanaged
    {
        void CheckMatch<F>(F f)
            where F : ISVShiftOp128DApi<T>
        {
            var w = w128;
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
                        eq(f.InvokeScalar(vcell(x,j), offset), vcell(z,j));
                }
            }
            catch(ClaimException e)
            {
                term.error(e, casename);
                succeeded = false;
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