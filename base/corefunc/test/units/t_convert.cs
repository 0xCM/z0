//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;
    using static zfunc;

    public sealed class t_convert : UnitTest<t_convert>
    {

        public void convert_32u_to_bytes_check()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<uint>();
                var y = x.AsBytes();
                Span<byte> z = BitConverter.GetBytes(x);
                Claim.numeq(y,z);
            }
        }

        public void convert_64u_to_bytes_check()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<ulong>();
                var y = x.AsBytes();
                Span<byte> z = BitConverter.GetBytes(x);
                Claim.numeq(y,z);
            }
        }

        public void convert_64f_to_bytes_check()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.Next<double>();
                var y = x.AsBytes();
                Span<byte> z = BitConverter.GetBytes(x);
                Claim.numeq(y,z);
            }
        }

    }

}