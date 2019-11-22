//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;

    public class t_vinc : IntrinsicTest<t_vinc>
    {


        public void vinc_128x8u()
            => inc_check<byte>(n128);

        public void vinc_128x8i()
            => inc_check<sbyte>(n128);

        public void vinc_128x32u()
            => inc_check<uint>(n128);

        public void vinc_256x8u()
            => inc_check<byte>(n256);

        public void vinc_256x8i()
            => inc_check<sbyte>(n256);

        public void vinc_256x32u()
            => inc_check<uint>(n256);

        void inc_check<T>(N128 n)
            where T : unmanaged
        {

            var blocks = SampleSize;
            var zb = DataBlocks.alloc<T>(n, blocks);
            var eb = DataBlocks.alloc<T>(n, blocks);            
            Claim.eq(zb.BlockCount, blocks);

            var blocklen = DataBlocks.blocklen<T>(n);
            
            for(var i=0; i<CycleCount; i++)
            {
                var xb = Random.Blocks<T>(n,blocks);
                vblock.inc(xb, zb);

                for(var block = 0; block < blocks; block++)
                for(var cell = 0; cell < blocklen; cell++)
                    eb.Block(block)[cell] = gmath.inc(xb.Block(block)[cell]);

                Claim.eq(eb,zb);
            }
        }

        void inc_check<T>(N256 n)
            where T : unmanaged
        {

            var blocks = SampleSize;
            var zb = DataBlocks.alloc<T>(n, blocks);
            var eb = DataBlocks.alloc<T>(n, blocks);
            Claim.eq(zb.BlockCount, blocks);

            var blocklen = DataBlocks.blocklen<T>(n);

            for(var i=0; i<CycleCount; i++)
            {
                var xb = Random.Blocks<T>(n,blocks);                
                vblock.inc(xb, zb);

                for(var block = 0; block < blocks; block++)
                for(var cell = 0; cell < blocklen; cell++)
                    eb.Block(block)[cell] = gmath.inc(xb.Block(block)[cell]);

                Claim.eq(eb,zb);
            }
        }

    }

}