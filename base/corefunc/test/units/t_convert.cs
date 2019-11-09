//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class t_convert : UnitTest<t_convert>
    {

        public void convert_32u_to_bytes_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<uint>();
                var y = x.AsBytes();
                Span<byte> z = BitConverter.GetBytes(x);
                Claim.eq(y,z);
            }
        }

        public void convert_64u_to_bytes_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<ulong>();
                var y = x.AsBytes();
                Span<byte> z = BitConverter.GetBytes(x);
                Claim.eq(y,z);
            }
        }

        public void convert_64f_to_bytes_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<double>();
                var y = x.AsBytes();
                Span<byte> z = BitConverter.GetBytes(x);
                Claim.eq(y,z);
            }
        }

    }

}