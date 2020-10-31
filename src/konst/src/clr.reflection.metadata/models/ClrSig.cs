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

    public readonly struct ClrSig : ITextual
    {
        public ClrArtifactKind ElementType {get;}

        public BinaryCode Data {get;}

        [MethodImpl(Inline)]
        public ClrSig(ClrArtifactKind kind, BinaryCode src)
        {
            ElementType = kind;
            Data = src;
        }

        public static ClrSig Empty
        {
            [MethodImpl(Inline)]
            get => new ClrSig(0, BinaryCode.Empty);
        }

        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();
    }
}