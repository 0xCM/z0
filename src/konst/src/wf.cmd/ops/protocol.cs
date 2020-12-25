//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Cmd
    {
        [MethodImpl(Inline), Factory]
        public ArgProtocol protocol(ArgPrefix prefix, AsciCharCode? qualifier = null)
            => new ArgProtocol(prefix, qualifier ?? AsciCharCode.Space);
    }
}