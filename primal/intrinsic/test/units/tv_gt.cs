//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vgt : UnitTest<t_vgt>
    {

        public void vgt_128x8i()
        {
            gt128_check<sbyte>();
        }

        public void gt128_i16()
        {
            gt128_check<short>();            
        }

        public void gt128_i32()
        {
            gt128_check<int>();
        }

        public void gt256i8()
        {
            gt256_check<sbyte>();
        }

        public void gt256i16()
        {
            gt256_check<short>();            
        }

        public void gt256_i32()
        {
            gt256_check<int>();
        }

        void gt128_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var v1 = Random.CpuVector128<T>();                
                var v2 = v1.Next();
                var cmp =  ginx.cmpgt(v2,v1);
                //Claim.yea(cmp);   
            }
        }

        void gt256_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var v1 = Random.CpuVector256<T>();                
                var v2 = v1.Next();
                var cmp = ginx.cmpgt(v2,v1);
                //Claim.yea(cmp);                    
            }
        }

    }

}