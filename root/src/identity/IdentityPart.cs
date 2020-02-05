//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public readonly struct IdentityPart
    {        
        public static IdentityPart Define(byte index, IdentityPartKind kind, string text)
            => new IdentityPart(index, kind, text);

        public static implicit operator IdentityPart((byte index, IdentityPartKind kind, string text) src)
            => new IdentityPart(src.index, src.kind, src.text);

        IdentityPart(byte index, IdentityPartKind kind, string text)
        {
            this.PartIndex = index;
            this.PartKind = kind;
            this.PartText = text;
        }
        
        public readonly byte PartIndex;

        public readonly IdentityPartKind PartKind;

        public readonly string PartText;

        public IdentityPart WithText(string src)
            => Define(PartIndex, PartKind, src);

        public override string ToString()
            => PartText;
        
    }
}