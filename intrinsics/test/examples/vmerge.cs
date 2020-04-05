//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Gone;
    using static VCore;

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
            var count = VCore.vcount(w,t);

            var x = gvec.vinc(w,t);
            var y = gvec.vinc(w, (x.LastCell() + 1));
            var z = dvec.vmergelo(x,y);
            var fmt = $"({x.Format()},{y.Format()}) -> {z.Format()}";
        }
        

        public void vmerge_example()
        {
            var a = VCore.vparts(n128, 0u,1,2,3);
            var b = VCore.vparts(n128, 4u,5,6,7);
            var c = VCore.vparts(n128, 8u,9,10,11);
            var d = VCore.vparts(n128, 12u,13,14,15);
            var x0 = dvec.vmergelo(v8u(a), v8u(b));
            var y0 = dvec.vmergelo(v8u(c), v8u(d));
            var z0 = v8u(dvec.vmergelo(v16u(x0),v16u(y0)));
            var z1 = v8u(dvec.vmergehi(v16u(x0),v16u(y0)));
            var x1 = dvec.vmergehi(v8u(a), v8u(b));
            var y1 = dvec.vmergehi(v8u(c), v8u(d));
            var z2 = v8u(dvec.vmergelo(v16u(x1),v16u(y1)));
            var z3 = v8u(dvec.vmergehi(v16u(x1),v16u(y1)));                            
        }

        public void vunpack_lo_8()
        {

            void report()
            {
                var x = Data.vincrements<byte>(n128);
                var y = dvec.vadd(x, VCore.vbroadcast(n128, (byte)16));

                var lo = gvec.vmergelo(x,y);
                var hi = gvec.vmergehi(x,y);

                Notify(x.FormatList(2));
                Notify(y.FormatList(2));
                Notify(lo.FormatList(2));
                Notify(hi.FormatList(2));
            }

            void merge_hi()
            {
                var w = n256;
                var t = z8;
                var x = gvec.vinc(w,t);
                var y = gvec.vinc(w, (byte)(x.LastCell() + 1));
                var z = dvec.vmergehi(x,y);
                Notify($"mergehi");
                Notify(x.Format(pad:2));
                Notify(y.Format(pad:2));
                Notify(z.Format(pad:2));
            }

            void merge()
            {
                var w = n256;
                var t = z8;
                var x = gvec.vinc(w,t);
                var y = gvec.vinc(w, (byte)(x.LastCell() + 1));
                var z = dvec.vmerge(x,y);
                Notify(x.Format(pad:2));
                Notify(y.Format(pad:2));
                Notify(z.Format(pad:2));
            }
        }
    }
}