//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ClrHandle
    {
        public ClrToken Token {get;}

        public ClrArtifactKind Kind {get;}

        public Ptr Pointer {get;}

        [MethodImpl(Inline)]
        public ClrHandle(ClrArtifactKind kind, ClrToken key, Ptr ptr)
        {
            Kind = kind;
            Token = key;
            Pointer = ptr;
        }
    }
}