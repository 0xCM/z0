//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static CliSig signature(Module module, ClrToken token)
            => module.ResolveSignature((int)token);
    }
}