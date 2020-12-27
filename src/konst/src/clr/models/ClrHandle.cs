//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    [Datatype]
    public readonly struct ClrHandle
    {
        public ClrArtifactKind Kind {get;}

        public ClrToken Key {get;}

        public Ptr Pointer {get;}

        [MethodImpl(Inline)]
        public ClrHandle(ClrArtifactKind kind, ClrToken key, Ptr ptr)
        {
            Kind = kind;
            Key = key;
            Pointer = ptr;
        }
    }
}