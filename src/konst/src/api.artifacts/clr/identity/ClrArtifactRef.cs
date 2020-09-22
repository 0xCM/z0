//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ClrArtifactRef : IClrArtifactRef
    {
        public ClrArtifactKind Kind {get;}

        public ApiArtifactKey Id {get;}

        public ClrName Name {get;}

        [MethodImpl(Inline)]
        public ClrArtifactRef(ApiArtifactKey id, ClrArtifactKind kind, ClrName name)
        {
            Id = id;
            Kind = kind;
            Name = name;
        }
    }
}