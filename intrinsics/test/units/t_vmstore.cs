//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;
    using static HexConst;

    public class t_vmstore : t_vinx<t_vmstore>
    {   
        const byte Y = Pow2.T07;

        const byte N = 0;

        public void vmstore_128x8()
        {
            var n = n128;
            var dst = DataBlocks.single<byte>(n);
            var m0 = CpuVector.parts(n128,Y,Y,Y,Y,N,N,N,N,N,N,N,N,N,N,N,N);
            var m1 = dinx.vsllx(m0,32);
            var m2 = dinx.vsllx(m1,32);
            var m3 = dinx.vsllx(m2,32);
            for(var i = 0; i<SampleSize; i++)
            {
                var v0 = Random.CpuVector<byte>(n);
                var v1 = Random.CpuVector<byte>(n);
                var v2 = Random.CpuVector<byte>(n);
                var v3 = Random.CpuVector<byte>(n);

                dinx.vmstore(v0, m0, dst);
                dinx.vmstore(v1, m1, dst);
                dinx.vmstore(v2, m2, dst);
                dinx.vmstore(v3, m3, dst);


                var v4 = ginx.vload(dst);
                var v5 = CpuVector.parts(n128, 
                    vcell(v0,0), vcell(v0,1), vcell(v0,2), vcell(v0,3),
                    vcell(v1,4), vcell(v1,5), vcell(v1,6), vcell(v1,7),
                    vcell(v2,8), vcell(v2,9), vcell(v2,A), vcell(v2,B),
                    vcell(v3,C), vcell(v3,D), vcell(v3,E), vcell(v3,F)
                    );
                
                Claim.eq(v4,v5);
            }
        }
    }
}