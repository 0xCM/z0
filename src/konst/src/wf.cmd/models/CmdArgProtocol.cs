//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdArgProtocol
    {
        public CmdArgPrefix Prefix {get;}

        public AsciCharCode Qualifier {get;}

        [MethodImpl(Inline)]
        public CmdArgProtocol(CmdArgPrefix delimiter, AsciCharCode qualifier)
        {
            Prefix = delimiter;
            Qualifier = qualifier;
        }

        [MethodImpl(Inline)]
        public CmdArgProtocol(CmdArgPrefix delimiter)
        {
            Prefix = delimiter;
            Qualifier = AsciCharCode.Space;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdArgProtocol(CmdArgPrefix prefix)
            => new CmdArgProtocol(prefix);
    }
}