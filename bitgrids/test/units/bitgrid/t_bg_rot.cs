//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bg_rot : t_bg<t_bg_rot>
    {        

        public void bg_rot_basecases()
        {
            void case1()
            {
                var w = n256;
                var m = n16;
                var n = n16;
                var t = z16;
                var pattern = (ushort)0b1100110011001100;
                var g = BitGrid.broadcast(pattern, BitGrid.alloc(w,m,n,t));
                //PostMessage(g.Format());
                g = BitGrid.rotl(g, 1);
                //PostMessage(g.Format());
            }

            void case2()
            {
                var w = n256;
                var m = n8;
                var n = n32;
                var t = z32;
                var pattern = 0b00000000_00000111_00000000_00000000u;
                var shifts = Vectors.vparts(w,1,1,4,4,0,0,1,1);
                var g0 = BitGrid.broadcast(pattern, BitGrid.alloc(w,m,n,t));
                
                //PostMessage("g0");
                //PostMessage(g0.Format());
                
                var g1 = BitGrid.sllv(g0, shifts);
                //PostMessage("sllv");
                //PostMessage(g1.Format());

                var g2 = BitGrid.srlv(g0, shifts);
                // PostMessage("srlv");
                // PostMessage(g2.Format());
            }

            case2();
        }

    }

}
        
