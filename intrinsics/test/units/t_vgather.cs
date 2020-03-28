//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static Core;
    using static Nats;
    using static refs;
    using static CastNumeric;

    public class t_vgather : t_vinx<t_vgather>
    {
        const int BufferSize = 1024*8;

        public void vgather_check()
        {
            vgather_check(w128);
            vgather_check(w256);
        }

        void vgather_check(W128 w)
        {
            vgather_check(w,z8);
            vgather_check(w,z8i);
            vgather_check(w,z16);
            vgather_check(w,z16i);
            vgather_check(w,z32);
            vgather_check(w,z32i);
            vgather_check(w,z64);
            vgather_check(w,z64i);
        }

        void vgather_check(W256 w)
        {
            vgather_check(w,z8);
            vgather_check(w,z8i);
            vgather_check(w,z16);
            vgather_check(w,z16i);
            vgather_check(w,z32);
            vgather_check(w,z32i);
            vgather_check(w,z64);
            vgather_check(w,z64i);
        }

        void vgather_check<T>(W128 w, T t = default)
            where T : unmanaged
        {
            void check()
            {
                var N = BufferSize/size<T>();
                var d = bounds(N,t);
                
                var data = gmath.increments(Spans.alloc(N,t));
                ref readonly var src = ref head(data);

                for(var rep = 0; rep < RepCount; rep++)
                {
                    var vidx = Random.CpuVector(w,d);            
                    var x = gvec.vgather(in src, vidx);
                    Claim.eq(vidx,x);
                }
            }

            CheckAction(check, CaseName("vgather", w, t));
        }

        void vgather_check<T>(W256 w, T t = default)
            where T : unmanaged
        {
            void check()
            {
                var N = BufferSize/size<T>();
                var d = bounds(N,t);
                
                var data = gmath.increments(Spans.alloc(N,t));
                ref readonly var src = ref head(data);

                for(var rep = 0; rep < RepCount; rep++)
                {
                    var vidx = Random.CpuVector(w,d);            
                    var x = gvec.vgather(in src, vidx);
                    Claim.eq(vidx,x);
                }
            }

            CheckAction(check, CaseName("vgather", w, t));
        }

        [MethodImpl(Inline)]
        static Interval<T> bounds<T>(int n, T t = default)
            where T : unmanaged
                => (Root.zero(t), convert<T>(n));        
    }
}
