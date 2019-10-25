//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Reflection;
    using System.ComponentModel;
    using System.Runtime.Intrinsics;

    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    public class t_vcreate : UnitTest<t_vcreate>
    {        

        public void CreateScalars()
        {
            {
                var vec1 = Vector128.Create(2,0,3,0);
                var vec2 = Vector128.Create(5,0,7,0);
                var expect = Vector128.Create(10L,21L);
                var result = Vector128.Create(0L,0L);
                result = dinx.vmul(vec1,vec2);
                Claim.eq(expect,result);
            }

            {
                var vec1 = Vector128.Create(2,0,3,0);
                var vec2 = Vector128.Create(5,0,7,0);                            
                var result = dinx.vmul(vec1,vec2);
                var expect =  Vector128.Create(vec1.ToScalar128(0) * vec2.ToScalar128(0), vec1.ToScalar128(2) * vec2.ToScalar128(2));
                Claim.eq(expect, result);                        
            
            }

            {
                var vec1 = Vector128.Create(2.0f, 3.0f, 4.0f, 5.0f);
                var vec2 = Vector128.Create(5.0f, 2.0f, 8.0f, 4.0f);
                var expect = Vector128.Create(10.0f, 6.0f, 32.0f, 20.0f);
                var result = Vector128.Create(0f,0f,0f,0f);
                result = dfp.vmul(vec1,vec2);
                Claim.eq(expect,result);
            }
        }

    }
}