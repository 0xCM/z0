//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_bit_index : t_sb<t_sb_bit_index>
    {
        public void bit_index_inc()
        {
            var pos = BitPos<byte>.Zero;
            BitPos<byte> max = (1024, 35);
            while(pos < max)
                pos++;

            Claim.eq(pos.BitIndex, max.BitIndex);

        }

        public void bit_index_dec()
        {
            var min = BitPos<byte>.Zero;
            BitPos<byte> pos = (1024, 35);
            while(pos > min)
                pos--;

            Claim.eq(pos.BitIndex, min.BitIndex);
        }

        public void bit_index_add()
        {
            var n = Pow2.T12;
            var positions = Random.BitPositions<uint>(512,1024).TakeArray(n);
            var additions = Random.Stream(closed(0u, 100u)).TakeArray(n);
            for(var i=0; i<n; i++)
            {
                var posX = positions[i];
                var add = additions[i];
                var posY = posX + add;
                Claim.yea(posY >= posX);

                var pos = posX;
                for(var j=0; j< add; j++)
                    pos++;
                
                Claim.eq(pos.BitIndex, posY.BitIndex);
            }            
        }
    }
}