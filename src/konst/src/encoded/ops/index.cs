//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static z;

    using static Konst;

    partial struct Encoded
    {
        [MethodImpl(Inline), Op]
        public static X86UriIndex index(ApiHostUri host, X86UriHex[] code)
            => new X86UriIndex(host,code);

        [MethodImpl(Inline), Op]
        public static X86PartHosts index(PartId part, X86HostIndex[] src)
            => new X86PartHosts(part,src);

        [MethodImpl(Inline), Op]
        public static X86HostIndex index(ApiHostUri id, X86ApiCode[] code)
            => new X86HostIndex(id,code);
    }
}