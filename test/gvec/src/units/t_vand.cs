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

    public class t_vand : t_inx<t_vand>
    {
        public void vand_check()
        {
            vand_check(n128);
            vand_check(n256);


            for(var i=0; i<RepCount; i++)
            {
                var x = Random.CpuVector(n128,z32);
                var y = Random.CpuVector(n128,z32);
                Claim.Require(vand(x,y));
            }
        }

        void vand_check(N128 w)
        {
            vand_check(w, z8);
            vand_check(w, z8i);
            vand_check(w, z16);
            vand_check(w, z16i);
            vand_check(w, z32);
            vand_check(w, z32i);
            vand_check(w, z64);
            vand_check(w, z64i);

        }

        void vand_check(N256 w)
        {
            vand_check(w, z8);
            vand_check(w, z8i);
            vand_check(w, z16);
            vand_check(w, z16i);
            vand_check(w, z32);
            vand_check(w, z32i);
            vand_check(w, z64);
            vand_check(w, z64i);
        }

        static Bit32 vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            var svc = gbits.bitlogic<T>();
            var v1 = VSvc.vbitlogic<T>(w128).and(x,y);

            var buffer = gcells.alloc<Cell128>();
            ref var dst = ref Cells.first<T>(buffer);
            var count = cpu.vcount<T>(w128);

            for(byte i=0; i< count; i++)
                seek(dst, i) = svc.and(vcell(x,i), vcell(y,i));
            var v2 = gcpu.vload(w128, dst);
            return gvec.vsame(v1,v2);
        }

        void vand_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckBinaryOp(VSvc.vand(w,t), w, t);

        void vand_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckBinaryOp(VSvc.vand(w,t), w, t);
     }
}
