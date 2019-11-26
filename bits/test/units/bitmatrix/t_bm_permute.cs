//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_permute : t_bm<t_bm_permute>
    {

        // public void perm_16x4()
        // {
        //     var A = Random.BitMatrix(n16,n4, 0ul);
        //     Trace(A.Format());
        //     var perm = A.ToPermutation();
        //     Trace(perm.Format());
            
        // }
        
        void permute_check<T>()
            where T : unmanaged
        {
            
            var A = BitMatrix.identity<T>();
            var N = BitMatrix<T>.N;
            for(var i=0; i< SampleSize; i++)
            {
                var perm = Random.Perm(N);
                BitMatrix.permute(perm, ref A);
            }
        }
    }

}