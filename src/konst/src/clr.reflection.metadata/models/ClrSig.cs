//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ClrSig
    {
        public ClrArtifactKind ElementType {get;}

        public byte[] Data {get;}

        public ClrSig(ClrArtifactKind kind, byte[] src)
        {
            ElementType = kind;
            Data = src;
        }
    }
}