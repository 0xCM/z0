//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using static z;

    using static Konst;

    partial struct Encoded
    {
        [MethodImpl(Inline), Op]
        public static ApiHexIndex index(ApiHostUri host, ApiHex[] code)
            => new ApiHexIndex(host,code);

        [MethodImpl(Inline), Op]
        public static X86PartMembers index(PartId part, EncodedMemberIndex[] src)
            => new X86PartMembers(part,src);

        [MethodImpl(Inline), Op]
        public static EncodedMemberIndex index(ApiHostUri id, X86ApiCode[] code)
            => new EncodedMemberIndex(id,code);
    }
}