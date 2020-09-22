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
        public static ApiHostCodeIndex index(ApiHostUri host, ApiHex[] code)
            => new ApiHostCodeIndex(host,code);

        [MethodImpl(Inline), Op]
        public static ApiPartCodeIndex index(PartId part, X86HostIndex[] src)
            => new ApiPartCodeIndex(part,src);

    }
}