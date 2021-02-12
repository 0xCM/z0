//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class t_mbspos : t_bitcore<t_mbspos>
    {
        public void msbpos_8()
            => check_msbpos<byte>();

        public void msbpos_16()
            => check_msbpos<ushort>();

        public void msbpos_32()
            => check_msbpos<uint>();

        public void msbpos_64()
            => check_msbpos<ulong>();

        void check_msbpos<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var xPos = gbits.hipos(x);
                CheckNumeric.lt(xPos, (byte)width<T>());

                var xCount = gbits.nlz(x);
                var y = BitString.scalar(x);
                var yCount = y.Nlz();
                CheckNumeric.eq(xCount, yCount);

                var yPos = y.Length - 1 - yCount;
                Claim.eq(xPos,yPos);
            }
        }
    }
}