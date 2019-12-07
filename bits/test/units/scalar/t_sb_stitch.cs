//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_stitch : t_sb<t_sb_stitch>
    {

        public void stitch_basecases()
        {
            void case1()
            {
                var x = 0b001111u;
                var y = 0b11111100000000u;
                var z = 0b1111111111;
                var s = gbits.stitch(x,2,y,2);
                Claim.eq(z,s);
            }

            void case2()
            {
                byte x = 0b00000011;            
                byte y = 0b00110000;
                byte z = 0b1111;
                var s = gbits.stitch(x, 1, y, 1);
                Claim.eq(z, s);
            }
            
            RunLocals();
            
        }


    }

}