//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vgather : t_vinx<t_vgather>
    {
        const int BufferSize = 1024*8;

        public void vgather_128x8u()
        {            
            const int N = BufferSize;

            var w = n128;
            var t = z8;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_128x8i()
        {            
            const int N = BufferSize;

            var w = n128;
            var t = z8i;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_128x16u()
        {            
            const int N = BufferSize/2;

            var w = n128;
            var t = z16;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_128x16i()
        {            
            const int N = BufferSize/2;

            var w = n128;
            var t = z16i;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_128x32u()
        {
            const int N = BufferSize;

            var w = n128;
            var t = z32;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_128x32i()
        {
            const int N = BufferSize;

            var w = n128;
            var t = z32i;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_128x64i()
        {
            const int N = BufferSize;

            var w = n128;
            var t = z64i;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_128x64u()
        {
            const int N = BufferSize;

            var w = n128;
            var t = z64;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_256x8i()
        {            
            const int N = BufferSize;

            var w = n256;
            var t = z8i;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_256x8u()
        {            
            const int N = BufferSize;

            var w = n256;
            var t = z8;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_256x16i()
        {            
            const int N = BufferSize/2;

            var w = n256;
            var t = z16i;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_256x16u()
        {            
            const int N = BufferSize/2;

            var w = n256;
            var t = z16;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_256x32i()
        {            
            const int N = BufferSize/2;

            var w = n256;
            var t = z32i;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_256x32u()
        {            
            const int N = BufferSize/4;

            var w = n256;
            var t = z32;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }
        }

        public void vgather_256x64i()
        {
            const int N = BufferSize/8;
         
            var w = n256;
            var t = z64i;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }            
        }

        public void vgather_256x64u()
        {
            const int N = BufferSize/8;
         
            var w = n256;
            var t = z64;
            var d = bounds(N,t);

            var data = gmath.increments(span(N,t));
            ref readonly var src = ref head(data);

            for(var rep = 0; rep < RepCount; rep++)
            {
                var vidx = Random.CpuVector(w,d);            
                var x = ginx.vgather(w, in src, vidx);
                Claim.eq(vidx,x);
            }            
        }

        [MethodImpl(Inline)]
        static Interval<T> bounds<T>(int n, T t = default)
            where T : unmanaged
                => (zero(t), convert<T>(n));        
    }
}
