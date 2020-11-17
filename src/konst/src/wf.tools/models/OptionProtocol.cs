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

    public readonly struct OptionProtocol
    {
        public OptionDelimiter Delimiter {get;}

        public AsciCharCode Qualifier {get;}

        [MethodImpl(Inline)]
        public OptionProtocol(OptionDelimiter delimiter, AsciCharCode qualifier)
        {
            Delimiter = delimiter;
            Qualifier = qualifier;
        }
    }
}