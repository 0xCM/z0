//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_pbv_enabled : t_bv<t_pbv_enabled>
    {
        public void pbv_enabled_64()
        {
            var src = Random.Span<byte>(Pow2.T03);
            var bv = BitVector.from(n64,BitConvert.ToUInt64(src));
            Claim.eq(src.ToBitString(), bv.ToBitString());

            for(var i=0; i<src.Length; i++)
            for(var j = 0; j < Pow2.T03; j++)
                Claim.eq(gbits.test(src[i],j), BitVector.enabled(bv,i*Pow2.T03 + j));
        }
    }
}


