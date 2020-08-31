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
        public static IdentifiedCodeIndex index(ApiHostUri host, IdentifiedCode[] code)
            => new IdentifiedCodeIndex(host,code);

        [MethodImpl(Inline), Op]
        public static PartCodeIndex index(PartId part, EncodedMemberIndex[] src)
            => new PartCodeIndex(part,src);

        [MethodImpl(Inline), Op]
        public static EncodedMemberIndex index(ApiHostUri id, X86ApiCode[] code)
            => new EncodedMemberIndex(id,code);
    }
}