//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_bitconvert : t_sb<t_sb_bitconvert>
    {
        static bit On = bit.On;
        static bit Off = bit.Off;

        public void bit_convert()
        {
            
            Claim.eq((byte)0, (byte)Off);
            Claim.eq((byte)1, (byte)On);

            Claim.eq((ushort)0, (ushort)Off);
            Claim.eq((ushort)1, (ushort)On);

            Claim.eq(0u, (uint)Off);
            Claim.eq(1u, (uint)On);

            Claim.eq(0ul, (ulong)Off);
            Claim.eq(1ul, (ulong)On);

        }

        public void bit_logic()
        {
            //parse
            Claim.eq(Off, Z0.Bit.Parse('0'));
            Claim.eq(On, Z0.Bit.Parse('1'));

            //flip
            Claim.eq(On, ~ Off);
            Claim.eq(Off, ~ On);

            //and
            Claim.eq(On, On & On);
            Claim.eq(Off, On & Off);
            Claim.eq(Off, Off & On);
            Claim.eq(Off, Off & Off);

            //or
            Claim.eq(On, Off | On);
            Claim.eq(On, On | Off);
            Claim.eq(Off, Off | Off);
            Claim.eq(On, On | On);
            
            
            //xor
            Claim.eq(On, Off ^ On);
            Claim.eq(On, On ^ Off);
            Claim.eq(Off, Off ^ Off);
            Claim.eq(Off, On ^ On);
        } 

    }

}
