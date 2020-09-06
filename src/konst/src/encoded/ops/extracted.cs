//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Encoded
    {
        [MethodImpl(Inline), Op]
        public static X86ApiExtract extracted(OpIdentity id, OpUri uri, ApiMember member, X86Code encoded)
            => new X86ApiExtract(id,uri,member,encoded);
    }
}