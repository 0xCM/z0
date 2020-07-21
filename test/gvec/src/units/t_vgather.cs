//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    
    public class t_vgather : t_inx<t_vgather>
    {
        const int BufferSize = 1024*8;

        public override bool Enabled 
            => true;

        [MethodImpl(Inline)]
        static Interval<T> bounds<T>(uint n)
            where T : unmanaged
                => (zero<T>(), convert<T>(n));        

        public void vgather_check()
        {
            //vgather_check(w128);
            //vgather_check(w256);
        }

        void vgather_check(W128 w)
        {
            vgather_check(w, z8);
            vgather_check(w, z8i);
            vgather_check(w, z16);
            vgather_check(w, z16i);
            vgather_check(w, z32);
            vgather_check(w, z32i);
            vgather_check(w, z64);
            vgather_check(w, z64i);
        }

        void vgather_check(W256 w)
        {
            vgather_check(w, z8);
            vgather_check(w, z8i);
            vgather_check(w, z16);
            vgather_check(w, z16i);
            vgather_check(w, z32);
            vgather_check(w, z32i);
            vgather_check(w, z64);
            vgather_check(w, z64i);
        }

        void vgather_check<T>(W128 w)
            where T : unmanaged
        {
            var cells = BufferSize/size<T>();
            var domain = bounds<T>(cells);
            
            var data = gmath.increments(span<T>(cells));
            ref readonly var src = ref first(data);

            for(var i = 0; i<RepCount; i++)
            {
                var vidx = Random.CpuVector(w,domain);            
                var x = gvec.vgather(src, vidx);
                Claim.veq(vidx,x);
            }
        }

        void vgather_check<T>(W256 w)
            where T : unmanaged
        {
            var count = BufferSize/size<T>();
            var domain = bounds<T>(count);
            
            var data = gmath.increments(span<T>(count));
            ref readonly var src = ref first(data);

            for(var i = 0; i<RepCount; i++)
            {
                var vidx = Random.CpuVector(w,domain);            
                var x = gvec.vgather(src, vidx);
                Claim.veq(vidx,x);
            }
        }

        void vgather_check<T>(W128 w, T t)
            where T : unmanaged
                => CheckAction(() => vgather_check<T>(w), CaseName("vgather", w, t));
        
        void vgather_check<T>(W256 w, T t)
            where T : unmanaged
                => CheckAction(() => vgather_check<T>(w), CaseName("vgather", w, t));
    }
}