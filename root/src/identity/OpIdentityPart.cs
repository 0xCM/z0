//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public readonly struct OpIdentityPart
    {        
        public static OpIdentityPart Define(byte index, OpIdentityPartKind kind, string text)
            => new OpIdentityPart(index, kind, text);

        public static implicit operator OpIdentityPart((byte index, OpIdentityPartKind kind, string text) src)
            => new OpIdentityPart(src.index, src.kind, src.text);

        OpIdentityPart(byte index, OpIdentityPartKind kind, string text)
        {
            this.PartIndex = index;
            this.PartKind = kind;
            this.PartText = text;
        }
        public readonly byte PartIndex;

        public readonly OpIdentityPartKind PartKind;

        public readonly string PartText;

        public OpIdentityPart WithText(string src)
            => Define(PartIndex, PartKind, src);

        public override string ToString()
            => PartText;
        
    }
}