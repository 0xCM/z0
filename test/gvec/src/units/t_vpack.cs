//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static z;

    public class t_vpack : t_inx<t_vpack>
    {
        public void vpackus_128x16x2_128x8_outline()
        {
            void case1()
            {
                var x = vparts(n128,0,1,2,4,4,5,6,7);
                var y = vparts(n128,8,9,10,11,12,13,14,15);
                var z = dvec.vpackus(x,y);
                var e = vparts(n128,0,1,2,4,4,5,6,7,8,9,10,11,12,13,14,15);
                Claim.veq(e,z);
            }

            void case2()
            {
                var x = vparts(n128,127,0,127,0,127,0,127,0);
                var y = dvec.vpackus(x,x);
                Notify(y.Format());
            }        
            case1();
            case2();            
        }
    }

}