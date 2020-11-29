//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct CmdArgs
    {
        [MethodImpl(Inline), Factory]
        public CmdArgProtocol protocol(CmdArgPrefix prefix, AsciCharCode qualifier = AsciCharCode.Space)
            => new CmdArgProtocol(prefix, qualifier);
    }
}