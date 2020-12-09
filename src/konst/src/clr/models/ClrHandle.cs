//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrHandle
    {
        public ClrArtifactKind Kind {get;}

        public CliArtifactKey Key {get;}

        public Ptr Pointer {get;}

        [MethodImpl(Inline)]
        public ClrHandle(ClrArtifactKind kind, CliArtifactKey key, Ptr ptr)
        {
            Kind = kind;
            Key = key;
            Pointer = ptr;
        }
    }
}