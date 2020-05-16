//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Analogs;
    public class t_uint4 : UnitTest<t_uint4>
    {
        public void add_4u_check()
        {
            var x = uint4(3u) + uint4(5u);
            Claim.eq(8u, x);

            var y = uint4(10u) + uint4(5u);
            Claim.eq(uint4_t.MaxValue,y);
        }

        public void inc_4u_check()
        {
            var i = uint4_t.MinValue;
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
            Claim.eq(i,uint4_t.MinValue);

        }

        public void dec_4u_check()
        {
            var i = uint4_t.MaxValue;
            i--;
            i--;
            i--;
            i--;
            Claim.eq(i, uint4_t.MaxValue - 4);

            i--;
            i--;
            i--;
            i--;
            Claim.eq(i, uint4_t.MaxValue - 8);

            i--;
            i--;
            i--;
            i--;
            Claim.eq(i, uint4_t.MaxValue - 12);

            i--;
            i--;
            i--;
            i--;
            Claim.eq(i,uint4_t.MaxValue);

        }

        public void uint4_create()
        {
            var x0 = (uint4_t)0;
            byte y0 = x0;
            var z0 = (byte)0;
            Claim.eq(y0,z0);

            var x1 = (uint4_t)5;
            byte y1 = x1;
            var z1 = (byte)5;
            Claim.eq(y1,z1);

            var x2 = Analogs.uint4(true,false,true,true);
            byte y2 = x2;
            var z2 = (byte)0b1101;
            Claim.eq(y2,z2);

            var x3 = Analogs.uint4(bit.On, bit.Off, bit.On, bit.On);
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
            var x0 = (uint4_t)0;
            var x1 = (uint4_t)1;
            var x2 = (uint4_t)2;
            var x3 = (uint4_t)3;
            Primal.eq(x0.Format(), "0");
            Primal.eq(x1.Format(), "1");
            Primal.eq(x2.Format(), "2");
            Primal.eq(x3.Format(), "3");

        }

        public void uint4_inc()
        {
            var x = (uint4_t)7;
            for(var i=0; i< 3; i++)
                x++;
            
            Claim.eq((uint4_t)10,x);

            for(var i=0; i< 3; i++)
                x++;

            Claim.eq((uint4_t)13,x);

            for(var i=0; i< 3; i++)
                x++;

            Claim.eq((uint4_t)0,x);

        }

        public void uint4_dec()
        {
            var x = (uint4_t)7;
            for(var i=0; i< 3; i++)
                x--;
            
            Claim.eq((uint4_t)4,x);

            for(var i=0; i< 3; i++)
                x--;

            Claim.eq((uint4_t)1,x);

            for(var i=0; i< 3; i++)
                x--;

            Claim.eq((uint4_t)14,x);

        }

        public void uint4_flip()
        {
            var x0 = (uint4_t)0b1011;
            var y0 = ~x0;
            var z0 = (uint4_t)0b0100;
            Claim.eq(y0,z0);
        }
       
        public void uint4_add()
        {
            var x1 = (uint4_t)3;
            var x2 = (uint4_t)4;
            var y0 = (uint4_t)7;
            var z0 = (uint4_t)10;
            var z1 = (uint4_t)1;
            Claim.eq(y0, x1 + x2);
            Claim.eq(z0, y0 + x1);
            Claim.eq(z1, z0 + y0);
        
        }

        public void uint4_hilo()
        {
            Claim.eq((uint4_t)0b11, ((uint4_t)0b1011).Lo);
            Claim.eq((uint4_t)0b10, ((uint4_t)0b1011).Hi);

            var x0 = (uint4_t)0b1011;
            x0.Lo = (uint4_t)0b01;
            x0.Hi = (uint4_t)0b01;
            var y0 = (uint4_t)0b0101;
            Claim.eq(y0,x0);            
        }
    }
}