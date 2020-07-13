//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    partial struct Encoded
    {
       public static int include(in EncodedIndexBuilder builder, params MemberCode[] src)
        {
            var count = 0;
            for(var i=0; i<src.Length; i++)
            {
                var code = src[i];
                if(!builder.CodeAddress.TryAdd(code.Address, code))
                    term.yellow($"The address {code.Address} has already been asoociated with code");
                else
                    count++;

                builder.UriAddress.TryAdd(code.Address, code.OpUri);
                builder.CodeUri.TryAdd(code.OpUri, code);
            }
            return count;
        }
    }
}