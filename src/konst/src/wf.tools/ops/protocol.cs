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
        public OptionProtocol protocol(OptionDelimiter delimiter, AsciCharCode qualifier = AsciCharCode.Space)
            => new OptionProtocol(delimiter, qualifier);
    }
}