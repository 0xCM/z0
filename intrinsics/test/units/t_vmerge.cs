//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;
    using static HexConst;

    public class t_vmerge : t_vinx<t_vmerge>
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
            var count = ginx.vcount(w,t);

            var x = CpuVector.increments(w,t);
            var y = CpuVector.increments(w, (x.LastCell() + 1));
            var z = dinx.vmergelo(x,y);
            var fmt = $"({x.Format()},{y.Format()}) -> {z.Format()}";
            Trace(fmt);


        }
        

        public void vmerge_example()
        {
            var a = CpuVector.parts(n128, 0u,1,2,3);
            var b = CpuVector.parts(n128, 4u,5,6,7);
            var c = CpuVector.parts(n128, 8u,9,10,11);
            var d = CpuVector.parts(n128, 12u,13,14,15);
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



            /*
            mergehi
            [ 0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31]
            [32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63]
            [16, 48, 17, 49, 18, 50, 19, 51, 20, 52, 21, 53, 22, 54, 23, 55, 24, 56, 25, 57, 26, 58, 27, 59, 28, 60, 29, 61, 30, 62, 31, 63]

            */

            void report()
            {
                var x = CpuVector.increments<byte>(n128);
                var y = dinx.vadd(x, dinx.vbroadcast(n128, (byte)16));

                var lo = ginx.vmergelo(x,y);
                var hi = ginx.vmergehi(x,y);

                Trace(x.Format(pad:2));
                Trace(y.Format(pad:2));
                Trace(lo.Format(pad:2));
                Trace(hi.Format(pad:2));
            }

            void merge_hi()
            {
                var w = n256;
                var t = z8;
                var x = CpuVector.increments(w,t);
                var y = CpuVector.increments(w, (byte)(x.LastCell() + 1));
                var z = dinx.vmergehi(x,y);
                Trace($"mergehi");
                Trace(x.Format(pad:2));
                Trace(y.Format(pad:2));
                Trace(z.Format(pad:2));
            }

            void merge()
            {
                var w = n256;
                var t = z8;
                var x = CpuVector.increments(w,t);
                var y = CpuVector.increments(w, (byte)(x.LastCell() + 1));
                var z = dinx.vmerge(x,y);
                Trace(x.Format(pad:2));
                Trace(y.Format(pad:2));
                Trace(z.Format(pad:2));
            }
            merge_hi();
        }
    }
}