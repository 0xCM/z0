//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static HexConst;

    public class t_vconvert : t_vinx<t_vconvert>
    {   


        public void block_32x8u_to_128x32u()
        {
            var blockA = DataBlocks.parts<byte>(n32,1,2,3,4);
            var x = dinx.vparts(n128,1,2,3,4);
            var blockB = x.ToBlock();            
            dinx.vmovblock(blockA, out Vector128<uint> y);
            var blockC = y.ToBlock();            
            Claim.eq(x,y);
            Claim.eq(blockB,blockC);            
        }


        public void block_64x8u_to_2x128x32u()
        {
            var block = DataBlocks.parts<byte>(n64,1,2,3,4,5,6,7,8);
            var xE = dinx.vparts(n128,1,2,3,4);
            var yE = dinx.vparts(n128,5,6,7,8);
            dinx.vmovblock(block, out Vector128<uint> xA, out Vector128<uint> yA);
            Claim.eq(xE, xA);
            Claim.eq(yE, yA);
        }

        public void block_32x8u_to_2x128x64u()
        {
            var block = DataBlocks.parts<byte>(n32,1,2,3,4);
            var xE = dinx.vparts(n128,1,2);
            var yE = dinx.vparts(n128,3,4);
            dinx.vmovblock(block, out Vector128<ulong> xA, out Vector128<ulong> yA);
            Claim.eq(xE, xA);
            Claim.eq(yE, yA);
        }

        public void block_128x8u_to_2x128x16u()
        {
            var block = DataBlocks.parts<byte>(n128,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
            var xE = dinx.vparts(n128,1,2,3,4,5,6,7,8);
            var yE = dinx.vparts(n128,9,10,11,12,13,14,15,16);
            dinx.vmovblock(block, out Vector128<ushort> xA, out Vector128<ushort> yA);
            Claim.eq(xE, xA);
            Claim.eq(yE, yA);
        }

        public void v128x8u_v128x16u()
        {
            var x = dinx.vparts(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y = dinx.vconvert(x, out Vector128<ushort> _);
            var z = dinx.vparts(n128,0,1,2,3,4,5,6,7);
            Claim.eq(y,z);
        }

        public void m64x8u_v128x16u()
        {
            var x = DataBlocks.parts<byte>(n64,0,1,2,3,4,5,6,7);
            var y = dinx.vmovblock(x, out Vector128<ushort> _);
            var z = dinx.vparts(n128,0,1,2,3,4,5,6,7);            

            Claim.eq(y,z);            
        }

        public void blockspan_128x8u_v128x16u()
        {
            var x = DataBlocks.parts<byte>(n128,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            dinx.vmovblock(x, out Vector128<ushort> y0, out Vector128<ushort> y1);
            var z0 = x.LoBlock(0);
            var z1 = x.HiBlock(0);
            var y0s = y0.ToSpan();
            var y1s = y1.ToSpan();

            for(var i=0; i <8; i++)
            {
                Claim.eq(z0[i], (byte)y0s[i]);
                Claim.eq(z1[i], (byte)y1s[i]);
            }                                 
        }

        public void blockspan_64x8u_v2x128x32u()
        {
            var x = DataBlocks.parts<byte>(n64,0,1,2,3,4,5,6,7);
            dinx.vmovblock(x, out Vector128<uint> y0, out Vector128<uint> y1);
            var z0 = x.Slice(0,4);
            var z1 = x.Slice(4,4);
            var y0s = y0.ToSpan();
            var y1s = y1.ToSpan();

            for(var i=0; i <4; i++)
            {
                Claim.eq(z0[i], (byte)y0s[i]);
                Claim.eq(z1[i], (byte)y1s[i]);
            }                                 
        }
    }
}