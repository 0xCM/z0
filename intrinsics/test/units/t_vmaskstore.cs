//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static HexConst;

    public class t_vmaskstore : t_vinx<t_vmaskstore>
    {   
        public void vmstore_128x8()
        {
            const byte Y = Pow2.T07;
            const byte N = 0;

            var n = n128;
            var dst = DataBlocks.single<byte>(n);
            var m0 = CpuVector.vparts(n128,Y,Y,Y,Y,N,N,N,N,N,N,N,N,N,N,N,N);
            var m1 = dinx.vsllx(m0,32);
            var m2 = dinx.vsllx(m1,32);
            var m3 = dinx.vsllx(m2,32);

            for(var i = 0; i<RepCount; i++)
            {
                var v0 = Random.CpuVector<byte>(n);
                var v1 = Random.CpuVector<byte>(n);
                var v2 = Random.CpuVector<byte>(n);
                var v3 = Random.CpuVector<byte>(n);

                dinx.vmaskstore(v0, m0, dst);
                dinx.vmaskstore(v1, m1, dst);
                dinx.vmaskstore(v2, m2, dst);
                dinx.vmaskstore(v3, m3, dst);

                var v4 = CpuVector.vload(dst);
                var v5 = CpuVector.vparts(n128, 
                    vcell(v0,0), vcell(v0,1), vcell(v0,2), vcell(v0,3),
                    vcell(v1,4), vcell(v1,5), vcell(v1,6), vcell(v1,7),
                    vcell(v2,8), vcell(v2,9), vcell(v2,A), vcell(v2,B),
                    vcell(v3,C), vcell(v3,D), vcell(v3,E), vcell(v3,F)
                    );
                
                Claim.eq(v4,v5);
            }
        }

        public void vmaskstore_256x8()
        {
            var count = 32;
            var x = Random.CpuVector(n256,z8);
            var storage = DataBlocks.single(n256,z8);
            var stored = CpuVector.vzero(n256,z8);
            var mask = CpuVector.vzero(n256,z8);

            // Store every component
            storage.Clear();
            mask = VMask.vmsb(n256, n8, n1, z8);
            ginx.vmaskstore8(x,mask,storage);
            stored = storage.LoadVector();
            Claim.eq(x,stored);

            // Store odd components
            storage.Clear();
            mask = VMask.vmsb(n256, n16, n1, z8);
            ginx.vmaskstore8(x,mask,storage);
            stored = storage.LoadVector();


            for(var i=0; i< count; i++)
                if(odd(i)) 
                    Claim.eq(vcell(x,i), storage[i]);
                else
                    Claim.eq(z8, storage[i]);

            // Store even components
            storage.Clear();
            mask = ginx.vbsrl(VMask.vmsb(n256,n16,n1,z8),1);
            ginx.vmaskstore8(x, mask, storage);
            stored = storage.LoadVector();


            for(var i=0; i< count; i++)
                if(even(i)) 
                    Claim.eq(vcell(x,i), storage[i]);
                else
                    Claim.eq(z8, storage[i]);




            void report()
            {
                Trace("input", x.Format());            
                Trace("mask", mask.FormatBits());
                Trace("stored", stored.Format());
            }

        }
    }
}