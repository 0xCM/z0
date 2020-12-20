//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CliArtifactRef : ICliArtifact
    {
        public ClrArtifactKind Kind {get;}

        public CliKey Key {get;}

        public StringRef Name {get;}

        [MethodImpl(Inline)]
        public CliArtifactRef(CliKey id, ClrArtifactKind kind, StringRef name)
        {
            Key = id;
            Kind = kind;
            Name = name;
        }
    }
}