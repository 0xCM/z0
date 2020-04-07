//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    public class t_msbpos : t_bitcore<t_msbpos>
    {
        public void msbpos_8()
            => msbpos_check<byte>();

        public void msbpos_16()
            => msbpos_check<ushort>();

        public void msbpos_32()
            => msbpos_check<uint>();

        public void msbpos_64()
            => msbpos_check<ulong>();
 
        void msbpos_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var xpos = gbits.msbpos(x);
                CheckNumeric.lt(xpos, (int)bitsize<T>());
                
                var xcount = gbits.nlz(x);
                var bs = BitString.scalar(x);
                var bscount = bs.Nlz();
                CheckNumeric.eq(xcount, bscount);
                
                var bspos = bs.Length - 1 - bscount;
                Claim.eq(xpos,bspos);
            }
        }
 
    }

}