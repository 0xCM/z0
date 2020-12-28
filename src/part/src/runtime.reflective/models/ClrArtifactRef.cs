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
    public readonly struct ClrArtifactRef : ITextual
    {
        public ClrArtifactKind Kind {get;}

        public ClrToken Token {get;}

        public Name Name {get;}

        [MethodImpl(Inline)]
        public ClrArtifactRef(ClrToken id, ClrArtifactKind kind, string name)
        {
            Token = id;
            Kind = kind;
            Name = name;
        }

        public string Format()
            => string.Format(RP.PSx3, Kind, Token, Name);

        public override string ToString()
            => Format();
    }
}