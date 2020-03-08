//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityShare;

    public readonly struct IdentityPart : IIdentity<IdentityPart>
    {        
        public readonly byte PartIndex;

        public readonly IdentityPartKind PartKind;

        public string Identifier {get;}

        /// <summary>
        /// Defines an identity part
        /// </summary>
        /// <param name="width">The scalar bit-width</param>
        [MethodImpl(Inline)]
        public static IdentityPart Define(byte index, IdentityPartKind kind, string text)
            => new IdentityPart(index, kind, text);
        
        public static implicit operator IdentityPart((byte index, IdentityPartKind kind, string text) src)
            => Define(src.index, src.kind, src.text);

        [MethodImpl(Inline)]
        public static implicit operator string(IdentityPart src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(IdentityPart a, IdentityPart b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(IdentityPart a, IdentityPart b)
            => !a.Equals(b);

        IdentityPart(byte index, IdentityPartKind kind, string text)
        {
            this.PartIndex = index;
            this.PartKind = kind;
            this.Identifier = text;
        }
        
        public IdentityPart WithText(string src)
            => Define(PartIndex, PartKind, src);
        
        [MethodImpl(Inline)]
        public bool Equals(IdentityPart src)
            => equals(this, src);

        public override string ToString()
            => Identifier;
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public int CompareTo(IdentityPart other)
            => compare(this, other);        
    }
}