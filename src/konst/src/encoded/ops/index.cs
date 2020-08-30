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
        [Op]
        public static EncodedPartBuilder builder()
            => new EncodedPartBuilder(
                codes : z.dict<MemoryAddress,X86ApiCode>(),
                addresses : z.dict<MemoryAddress,OpUri>(),
                identities: z.dict<OpUri,X86ApiCode>());

        [MethodImpl(Inline), Op]
        public static IdentifiedCodeIndex index(ApiHostUri host, IdentifiedCode[] code)
            => new IdentifiedCodeIndex(host,code);

        [MethodImpl(Inline), Op]
        public static PartCode index(PartId part, EncodedMembers[] src)
            => new PartCode(part,src);

        [MethodImpl(Inline), Op]
        public static EncodedMembers index(ApiHostUri id, X86ApiCode[] code)
            => new EncodedMembers(id,code);
    }
}