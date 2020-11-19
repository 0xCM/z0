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

    public readonly struct CmdArgProtocol
    {
        public CmdArgDelimiter Delimiter {get;}

        public AsciCharCode Qualifier {get;}

        [MethodImpl(Inline)]
        public CmdArgProtocol(CmdArgDelimiter delimiter, AsciCharCode qualifier)
        {
            Delimiter = delimiter;
            Qualifier = qualifier;
        }
    }
}