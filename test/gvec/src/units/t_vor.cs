//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public class t_vor : t_inx<t_vor>
    {
        public void vor_check()
        {            
            vor_check(n128);
            vor_check(n256);
        }

        void vor_check(N128 w)
        {
            vor_check(w, z8);                
            vor_check(w, z8i);
            vor_check(w, z16);
            vor_check(w, z16i);
            vor_check(w, z32);
            vor_check(w, z32i);
            vor_check(w, z64);
            vor_check(w, z64i);

        }

        void vor_check(N256 w)
        {
            vor_check(w, z8);                
            vor_check(w, z8i);
            vor_check(w, z16);
            vor_check(w, z16i);
            vor_check(w, z32);
            vor_check(w, z32i);
            vor_check(w, z64);
            vor_check(w, z64i);
        }            

        void vor_check<T>(N128 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckBinaryOp(VSvc.vor(w,t),w,t);
            
        void vor_check<T>(N256 w, T t = default)
            where T : unmanaged
                => CheckSVF.CheckBinaryOp(VSvc.vor(w,t),w,t);

        public void vor_128x8i()
            => vor_check<sbyte>(n128);

        public void vor_128x8u()
            => vor_check<byte>(n128);            

        public void vor_128x16i()
            => vor_check<short>(n128);

        public void vor_128x16u()
            => vor_check<ushort>(n128);

        public void vor_128x32i()
            => vor_check<int>(n128);

        public void vor_128x32u()
            => vor_check<uint>(n128);            

        public void vor_128x64i()
            => vor_check<long>(n128);            

        public void vor_128x64u()
            => vor_check<ulong>(n128);            

        public void vor_256x8i()
            => vor_check<sbyte>(n256);

        public void vor_256x8u()
            => vor_check<byte>(n256);            

        public void vor_256x16i()
            => vor_check<short>(n256);

        public void vor_256x16u()
            => vor_check<ushort>(n256);

        public void vor_256x32i()
            => vor_check<int>(n256);

        public void vor_256x32u()
            => vor_check<uint>(n256);            

        public void vor_256x64i()
            => vor_check<long>(n256);            

        public void vor_256x64u()
            => vor_check<ulong>(n256);            

        public void vor_blocks_128x8i()
            => vor_blocks_check<sbyte>(n128);

        public void vor_blocks_256x8i()
            => vor_blocks_check<sbyte>(n256);

        public void vor_blocks_128x8u()
            => vor_blocks_check<byte>(n128);

        public void vor_blocks_128x16i()
            => vor_blocks_check<short>(n128);

        public void vor_blocks_128x16u()
            => vor_blocks_check<ushort>(n128);

        public void vor_blocks_128x32i()
            => vor_blocks_check<int>(n128);

        public void vor_blocks_128x32u()
            => vor_blocks_check<uint>(n128);

        public void vor_blocks_128x64i()
            => vor_blocks_check<long>(n128);

        public void vor_blocks_128x64u()
            => vor_blocks_check<ulong>(n128);

        public void vor_blocks_256x8u()
            => vor_blocks_check<byte>(n256);

        public void vor_blocks_256x16i()
            => vor_blocks_check<short>(n256);

        public void vor_blocks_256x16u()
            => vor_blocks_check<ushort>(n256);

        public void vor_blocks_256x32i()
            => vor_blocks_check<int>(n256);

        public void vor_blocks_256x32u()
            => vor_blocks_check<uint>(n256);

        public void vor_blocks_256x64i()
            => vor_blocks_check<long>(n256);

        public void vor_blocks_256x64u()
            => vor_blocks_check<ulong>(n256);

        protected void vor_blocks_check<T>(W128 w, T t = default)
            where T : unmanaged
        {
            var blocks = RepCount;
            var stats = GridCells.metrics(blocks,w,t);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var xb = Random.Blocks<T>(w, blocks);
            var yb = Random.Blocks<T>(w, blocks);
            var zb = Z0.Blocks.alloc<T>(w, blocks);
            Blocked.or(xb,yb,zb);
            
            for(var i=0; i<cells; i++)
                Claim.Eq(gmath.or(xb[i],yb[i]), zb[i]);
        }

        protected void vor_blocks_check<T>(W256 w, T t = default)
            where T : unmanaged
        {
            var blocks = RepCount;
            var stats = GridCells.metrics(blocks,w,t);
            var step = stats.BlockLength;
            var cells = stats.CellCount;

            var xb = Random.Blocks<T>(w, blocks);
            var yb = Random.Blocks<T>(w, blocks);
            var zb = Z0.Blocks.alloc<T>(w, blocks);
            Blocked.or(xb,yb,zb);
            
            for(var i=0; i<cells; i++)
                Claim.Eq(gmath.or(xb[i],yb[i]), zb[i]);
        }    
    }
}