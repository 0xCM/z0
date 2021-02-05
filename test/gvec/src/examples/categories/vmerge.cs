//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    partial class VexExamples
    {
        [Op(ExampleGroups.Merge)]
        public void vmerge_128()
        {
            var a = cpu.vparts(w128, 0u,1,2,3);
            var b = cpu.vparts(w128, 4u,5,6,7);
            var c = cpu.vparts(w128, 8u,9,10,11);
            var d = cpu.vparts(w128, 12u,13,14,15);
            var x0 = cpu.vmergelo(v8u(a), v8u(b));
            var y0 = cpu.vmergelo(v8u(c), v8u(d));
            var z0 = v8u(cpu.vmergelo(v16u(x0),v16u(y0)));
            var z1 = v8u(cpu.vmergehi(v16u(x0),v16u(y0)));
            var x1 = cpu.vmergehi(v8u(a), v8u(b));
            var y1 = cpu.vmergehi(v8u(c), v8u(d));
            var z2 = v8u(cpu.vmergelo(v16u(x1),v16u(y1)));
            var z3 = v8u(cpu.vmergehi(v16u(x1),v16u(y1)));
        }

        [Op(ExampleGroups.Merge)]
        public void vmerge_lo()
        {
            /*
            [ 0,  1,  2,  3,  4,  5,  6,  7]
            [ 8,  9, 10, 11, 12, 13, 14, 15]
            [ 4, 12,  5, 13,  6, 14,  7, 15]
            */

            var w = n256;
            var t = z32;
            var count = cpu.vcount(w,t);
            var a = gvec.vinc(w,t);
            var b = gvec.vinc(w, (a.LastCell() + 1));
            var c = cpu.vmergelo(a,b);
            var fmt = $"({a.Format()},{b.Format()}) -> {c.Format()}";
        }

        [Op(ExampleGroups.Merge)]
        public void vmerge_256()
        {
            var w = n256;
            var t = z8;
            var x = gvec.vinc(w,t);
            var y = gvec.vinc(w, (byte)(x.LastCell() + 1));
            var _z = cpu.vmerge(x,y);
            Notify($"vmerge_256");
            Notify(x.Format());
            Notify(y.Format());
            Notify(_z.Format());
        }

        [Op(ExampleGroups.Merge)]
        public void vmerge_hi()
        {
            var w = n256;
            var t = z8;
            var x = gvec.vinc(w,t);
            var y = gvec.vinc(w, (byte)(x.LastCell() + 1));
            var _z = cpu.vmergehi(x,y);
            Notify($"vmerge_hi");
            Notify(x.Format());
            Notify(y.Format());
            Notify(_z.Format());
        }

        [Op(ExampleGroups.Merge)]
        public void vmerge_hilo()
        {
            var x = gcpu.vinc<byte>(n128);
            var y = cpu.vadd(x, cpu.vbroadcast(n128, (byte)16));

            var lo = gcpu.vmergelo(x,y);
            var hi = gcpu.vmergehi(x,y);

            Notify($"vmerge_hilo");
            Notify(x.Format());
            Notify(y.Format());
            Notify(lo.Format());
            Notify(hi.Format());
        }
    }
}