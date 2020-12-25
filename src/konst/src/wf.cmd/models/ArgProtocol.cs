//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ArgProtocol
    {
        public ArgPrefix Prefix {get;}

        public ArgQualifier Qualifier {get;}

        [MethodImpl(Inline)]
        public ArgProtocol(ArgPrefix delimiter, ArgQualifier qualifier)
        {
            Prefix = delimiter;
            Qualifier = qualifier;
        }

        [MethodImpl(Inline)]
        public ArgProtocol(ArgPrefix delimiter)
        {
            Prefix = delimiter;
            Qualifier = AsciCharCode.Space;
        }

        [MethodImpl(Inline)]
        public static implicit operator ArgProtocol(ArgPrefix prefix)
            => new ArgProtocol(prefix);
    }
}