//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static CpuVector;
    using static dinx;

    partial class vexamples
    {
        public void vmergehi_256x32u()
        {
            /*
            [ 0,  1,  2,  3,  4,  5,  6,  7]
            [ 8,  9, 10, 11, 12, 13, 14, 15]
            [ 4, 12,  5, 13,  6, 14,  7, 15]
            */
            
            var w = n256;
            var t = z32;
            var count = CpuVector.vcount(w,t);

            var x = vpattern.vincrements(w,t);
            var y = vpattern.vincrements(w, (x.LastCell() + 1));
            var z = dinx.vmergelo(x,y);
            var fmt = $"({x.Format()},{y.Format()}) -> {z.Format()}";
        }
        

        public void vmerge_example()
        {
            var a = CpuVector.vparts(n128, 0u,1,2,3);
            var b = CpuVector.vparts(n128, 4u,5,6,7);
            var c = CpuVector.vparts(n128, 8u,9,10,11);
            var d = CpuVector.vparts(n128, 12u,13,14,15);
            var x0 = dinx.vmergelo(v8u(a), v8u(b));
            var y0 = dinx.vmergelo(v8u(c), v8u(d));
            var z0 = v8u(dinx.vmergelo(v16u(x0),v16u(y0)));
            var z1 = v8u(dinx.vmergehi(v16u(x0),v16u(y0)));
            var x1 = dinx.vmergehi(v8u(a), v8u(b));
            var y1 = dinx.vmergehi(v8u(c), v8u(d));
            var z2 = v8u(dinx.vmergelo(v16u(x1),v16u(y1)));
            var z3 = v8u(dinx.vmergehi(v16u(x1),v16u(y1)));                            
        }

        public void vunpack_lo_8()
        {

            void report()
            {
                var x = vpattern.vincrements<byte>(n128);
                var y = dinx.vadd(x, CpuVector.vbroadcast(n128, (byte)16));

                var lo = ginx.vmergelo(x,y);
                var hi = ginx.vmergehi(x,y);

                PostMessage(x.Format(pad:2));
                PostMessage(y.Format(pad:2));
                PostMessage(lo.Format(pad:2));
                PostMessage(hi.Format(pad:2));
            }

            void merge_hi()
            {
                var w = n256;
                var t = z8;
                var x = vpattern.vincrements(w,t);
                var y = vpattern.vincrements(w, (byte)(x.LastCell() + 1));
                var z = dinx.vmergehi(x,y);
                PostMessage($"mergehi");
                PostMessage(x.Format(pad:2));
                PostMessage(y.Format(pad:2));
                PostMessage(z.Format(pad:2));
            }

            void merge()
            {
                var w = n256;
                var t = z8;
                var x = vpattern.vincrements(w,t);
                var y = vpattern.vincrements(w, (byte)(x.LastCell() + 1));
                var z = dinx.vmerge(x,y);
                PostMessage(x.Format(pad:2));
                PostMessage(y.Format(pad:2));
                PostMessage(z.Format(pad:2));
            }
        }

    }

}