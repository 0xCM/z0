//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        partial struct Types
        {
            [MethodImpl(Inline), Op]
            public static BlittableKind typekind(byte index)
                => skip(TypeKinds, index);

        }
    }
}