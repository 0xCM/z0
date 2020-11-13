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
    using static z;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CliArtifactRef : ICliArtifact
    {
        public ClrArtifactKind Kind {get;}

        public ClrArtifactKey Key {get;}

        public StringRef Name {get;}

        [MethodImpl(Inline)]
        public CliArtifactRef(ClrArtifactKey id, ClrArtifactKind kind, StringRef name)
        {
            Key = id;
            Kind = kind;
            Name = name;
        }
    }
}