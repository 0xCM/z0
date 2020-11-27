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

    public class t_hipos : t_bitcore<t_hipos>
    {
        public void hipos_8()
            => hipos_check<byte>();

        public void hipos_16()
            => hipos_check<ushort>();

        public void hipos_32()
            => hipos_check<uint>();

        public void hipos_64()
            => hipos_check<ulong>();

        void hipos_check<T>(T t = default)
            where T : unmanaged
        {
            for(var i=0; i< RepCount; i++)
            {
                var x = Random.Next<T>();
                var xPos = gbits.hipos(x);
                CheckNumeric.lt(xPos, (byte)bitwidth<T>());

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