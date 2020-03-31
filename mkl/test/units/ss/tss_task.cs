//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;

    public class tss_task : UnitTest<tss_task>
    {
        public void radixSort()
        {
            var obs = Pow2.T10;
            var dim = Pow2.T08;
            var range = Interval.closed(-20f,20f);
            
            var src = Random.Array<float>(dim*obs, range);
            var sample = Dataset.Load(src,dim);
            var sorted = sample.RadixSort();

            for(var i = 0; i<obs; i++)
            {
                var v = sorted.Observation(i);
                for(var j = 0; j< dim - 1; j++)
                    CheckNumeric.lteq(v[j], v[j+1]);                    
            }                    
        }
    }
}