//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public readonly struct MonikerPart
    {        
        public static MonikerPart Define(byte index, MonikerPartKind kind, string text)
            => new MonikerPart(index, kind, text);

        public static implicit operator MonikerPart((byte index, MonikerPartKind kind, string text) src)
            => new MonikerPart(src.index, src.kind, src.text);

        MonikerPart(byte index, MonikerPartKind kind, string text)
        {
            this.PartIndex = index;
            this.PartKind = kind;
            this.PartText = text;
        }
        public readonly byte PartIndex;

        public readonly MonikerPartKind PartKind;

        public readonly string PartText;

        public MonikerPart WithText(string src)
            => Define(PartIndex, PartKind, src);

        public override string ToString()
            => PartText;
        
    }
}