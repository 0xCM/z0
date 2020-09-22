//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct EncodedX86
    {
        [MethodImpl(Inline), Op]
        public static ApiHostHexIndex index(ApiHostUri host, ApiHex[] code)
            => new ApiHostHexIndex(host,code);

        [MethodImpl(Inline), Op]
        public static ApiPartHexIndex index(PartId part, X86HostIndex[] src)
            => new ApiPartHexIndex(part,src);

        [MethodImpl(Inline), Op]
        public static X86HostIndex index(ApiHostUri id, X86ApiCode[] code)
            => new X86HostIndex(id,code);
    }
}