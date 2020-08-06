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
                CodeAddress : z.dict<MemoryAddress,MemberCode>(),
                UriAddress : z.dict<MemoryAddress,OpUri>(),
                CodeUri: z.dict<OpUri,MemberCode>());

        [MethodImpl(Inline), Op]
        public static IdentifiedCodeIndex index(ApiHostUri host, IdentifiedCode[] code)                    
            => new IdentifiedCodeIndex(host,code);

        [MethodImpl(Inline), Op]
        public static PartCode index(PartId part, EncodedMembers[] src)
            => new PartCode(part,src);

        [MethodImpl(Inline), Op]
        public static EncodedMembers index(ApiHostUri id, MemberCode[] code)
            => new EncodedMembers(id,code);     
    }
}