//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ApiSigs
    {
        [MethodImpl(Inline), Op]
        public static TypeParameter parameter(ushort position, Name name)
            => new TypeParameter(position, name);

        [MethodImpl(Inline), Op]
        public static TypeParameter parameter(ushort position, Name name, TypeSig closure)
            => new TypeParameter(position, name, closure);
    }
}
