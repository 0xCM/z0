//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Tooling
    {
        [MethodImpl(Inline), Factory]
        public CmdArgProtocol protocol(CmdArgDelimiter delimiter, AsciCharCode qualifier = AsciCharCode.Space)
            => new CmdArgProtocol(delimiter, qualifier);
    }
}