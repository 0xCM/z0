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
        public static EncodedIndexBuilder indexer()
            => new EncodedIndexBuilder(
                CodeAddress : core.dict<MemoryAddress,MemberCode>(),
                UriAddress : core.dict<MemoryAddress,OpUri>(),
                CodeUri: core.dict<OpUri,MemberCode>());

        [MethodImpl(Inline), Op]
        public static IdentifiedCodeIndex index(ApiHostUri host, IdentifiedCode[] code)                    
            => new IdentifiedCodeIndex(host,code);

        [MethodImpl(Inline), Op]
        public static PartCodeIndex index(PartId part, MemberCodeIndex[] src)
            => new PartCodeIndex(part,src);

        [MethodImpl(Inline), Op]
        public static MemberCodeIndex index(ApiHostUri id, MemberCode[] code)
            => new MemberCodeIndex(id,code);     
    }
}