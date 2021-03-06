//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Part;
    using static cpu;

    partial class VexExamples
    {
        [Op(ExampleGroups.Perms)]
        public void e_vperm4x16()
        {
            var id = vparts(w128,0,1,2,3,6,7,8,9);
            VClaims.veq(vperm4x16(vparts(w128,0,1,2,3,6,7,8,9), Perm4L.ADCB, Perm4L.ADCB), vparts(w128,0,3,2,1,6,9,8,7));
        }

        [Op(ExampleGroups.Perms)]
        public void e_vperm4x32_128x32u_A()
        {
            var trace = false;
            var pSrc = Random.EnumValues<Perm4L>(x => (byte)x > 5);

            for(var i=0; i<CycleCount; i++)
            {
                var v1 = Random.CpuVector<uint>(n128);
                var v1s = v1.ToSpan();
                var p = pSrc.First();

                // Disassemble the spec
                var p0 = BitMasks.gather((byte)p, (byte)0b11);
                var p1 = BitMasks.gather((byte)p, (byte)0b1100);
                var p2 = BitMasks.gather((byte)p, (byte)0b110000);
                var p3 = BitMasks.gather((byte)p, (byte)0b11000000);

                // Reassemble the spec
                Perm4L q = (Perm4L)(p0 | p1 << 2 | p2 << 4 | p3 << 6);

                // Same?
                Claim.eq(p,q);

                // Permute vector via api
                var v2 = vperm4x32(v1,p);

                // Permute vector manually
                var v3 = vparts(w128, v1s[p0],v1s[p1],v1s[p2],v1s[p3]);

                // Same?
                VClaims.veq(v3,v2);

                if(trace)
                {
                    base.Trace("v1", v1.FormatHex());
                    base.Trace("p", p.Format());
                    base.Trace("perm(v1,p)", v2.FormatHex());
                }
            }
        }

        [Op(ExampleGroups.Perms)]
        public void e_vperm4x32_128x32u_B()
        {
            var n = n128;
            var src = vparts(w128, 1,2,3,4);
            var spec = Perm4L.ABCD;
            var y = vparts(w128, 4,3,2,1);
            var x = vperm4x32(src, Perm4L.ABCD);
            VClaims.veq(x, src);

            y = vparts(w128,4,3,2,1);
            spec = Perm4L.DCBA;
            x = vperm4x32(src,spec);
            VClaims.veq(x, y);

            y = vparts(w128,4u,3u,2u,1u);
            spec = Perm4L.DCBA;
            x = vperm4x32(src,spec);
            VClaims.veq(x, y);

            VClaims.veq(vperm4x32(vparts(w128, 0,1,2,3), Perm4L.ADCB), vparts(w128, 0,3,2,1));
            VClaims.veq(vperm4x32(vparts(w128, 0,1,2,3), Perm4L.DBCA), vparts(w128, 3,1,2,0));
        }
    }
}