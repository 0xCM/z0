//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static BitSet;
    public class t_quartet : UnitTest<t_quartet>
    {
        public void add_4u_check()
        {
            var x = uint4(3u) + uint4(5u);
            Claim.eq(8u, x);

            var y = uint4(10u) + uint4(5u);
            Claim.eq(quartet.MaxValue,y);
        }

        public void inc_4u_check()
        {
            var i = quartet.MinValue;
            i++;
            i++;
            i++;
            i++;
            Claim.eq(i,4u);

            i++;
            i++;
            i++;
            i++;
            Claim.eq(i,8u);

            i++;
            i++;
            i++;
            i++;
            Claim.eq(i, 12u);

            i++;
            i++;
            i++;
            i++;
            Claim.eq(i,quartet.MinValue);

        }

        public void dec_4u_check()
        {
            var i = quartet.MaxValue;
            i--;
            i--;
            i--;
            i--;
            Claim.eq(i, quartet.MaxValue - 4);

            i--;
            i--;
            i--;
            i--;
            Claim.eq(i, quartet.MaxValue - 8);

            i--;
            i--;
            i--;
            i--;
            Claim.eq(i, quartet.MaxValue - 12);

            i--;
            i--;
            i--;
            i--;
            Claim.eq(i,quartet.MaxValue);

        }

        public void uint4_create()
        {
            var x0 = (quartet)0;
            byte y0 = x0;
            var z0 = (byte)0;
            Claim.eq(y0,z0);

            var x1 = (quartet)5;
            byte y1 = x1;
            var z1 = (byte)5;
            Claim.eq(y1,z1);

            var x2 = uint4(true,false,true,true);
            byte y2 = x2;
            var z2 = (byte)0b1101;
            Claim.eq(y2,z2);

            var x3 = uint4(bit.On, bit.Off, bit.On, bit.On);
            byte y3 = x3;
            var z3 = (byte)0b1101;
            Claim.eq(y3,z3);

            var x4 = uint4((byte)0);
            Claim.eq(x4,(byte)0);

            byte y4 = x4;
            var z4 = (byte)0;
            Claim.eq(y4,z4);

        }

        public void uint4_format()
        {
            var x0 = (quartet)0;
            var x1 = (quartet)1;
            var x2 = (quartet)2;
            var x3 = (quartet)3;
            PrimalSeq.eq(x0.Format(), "0");
            PrimalSeq.eq(x1.Format(), "1");
            PrimalSeq.eq(x2.Format(), "2");
            PrimalSeq.eq(x3.Format(), "3");

        }

        public void uint4_inc()
        {
            var x = (quartet)7;
            for(var i=0; i< 3; i++)
                x++;
            
            Claim.eq((quartet)10,x);

            for(var i=0; i< 3; i++)
                x++;

            Claim.eq((quartet)13,x);

            for(var i=0; i< 3; i++)
                x++;

            Claim.eq((quartet)0,x);

        }

        public void uint4_dec()
        {
            var x = (quartet)7;
            for(var i=0; i< 3; i++)
                x--;
            
            Claim.eq((quartet)4,x);

            for(var i=0; i< 3; i++)
                x--;

            Claim.eq((quartet)1,x);

            for(var i=0; i< 3; i++)
                x--;

            Claim.eq((quartet)14,x);

        }

        public void uint4_flip()
        {
            var x0 = (quartet)0b1011;
            var y0 = ~x0;
            var z0 = (quartet)0b0100;
            Claim.eq(y0,z0);
        }
       
        public void uint4_add()
        {
            var x1 = (quartet)3;
            var x2 = (quartet)4;
            var y0 = (quartet)7;
            var z0 = (quartet)10;
            var z1 = (quartet)1;
            Claim.eq(y0, x1 + x2);
            Claim.eq(z0, y0 + x1);
            Claim.eq(z1, z0 + y0);
        
        }

        public void uint4_hilo()
        {
            Claim.eq((quartet)0b11, ((quartet)0b1011).Lo);
            Claim.eq((quartet)0b10, ((quartet)0b1011).Hi);

            var x0 = (quartet)0b1011;
            x0.Lo = (quartet)0b01;
            x0.Hi = (quartet)0b01;
            var y0 = (quartet)0b0101;
            Claim.eq(y0,x0);            
        }
    }
}