//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public class t_scatter : ScalarBitTest<t_scatter>
    {        
        public void scatter_8x8()
            => scatter_check<byte>();

        public void scatter_16x16()
            => scatter_check<ushort>();

        public void scatter_32x32()
            => scatter_check<uint>();

        public void scatter_64x64()
            => scatter_check<ulong>();

        void scatter_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var src = Random.Next<T>();
                var mask = Random.Next<T>();
                var s1 = BitRef.scatter(src,mask);
                var s2 = gbits.scatter(src,mask);
                Claim.eq(s1,s2);
            }
        }

    }
}