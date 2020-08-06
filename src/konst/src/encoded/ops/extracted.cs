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
        public static ExtractedCode extracted(OpIdentity id, OpUri uri, ApiMember member, LocatedCode encoded)
            => new ExtractedCode(id,uri,member,encoded);
    }
}