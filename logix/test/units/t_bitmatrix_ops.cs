//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static TypedLogicSpec;

    public class t_bitmatrix_ops : UnitTest<t_bitmatrix_ops>
    {

        

        public void bm_and_check()
        {
            var A = Random.BitMatrix<uint>();
            var B = Random.BitMatrix<uint>();
            var C = Random.BitMatrix<uint>();
            var Z = BitMatrix.alloc<uint>();
            
            for(var i=0; i< SampleSize; i++)
            {
                
            }

        }

    }
}
