//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;
    using api = ApiIdentity;

    public readonly struct IdentityPart : IIdentification<IdentityPart>
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

        internal IdentityPart(byte index, IdentityPartKind kind, string text)
        {
            PartIndex = index;
            PartKind = kind;
            Identifier = text;
        }

        public bool IsName
            => PartKind == IdentityPartKind.Name;

        public bool IsSuffix
            => PartKind == IdentityPartKind.Suffix;

        public bool IsNumeric
            => PartKind == IdentityPartKind.Numeric;

        public bool IsSegment
            => PartKind == IdentityPartKind.Segment;

        public IdentityPart WithText(string src)
            => Define(PartIndex, PartKind, src);

        [MethodImpl(Inline)]
        public bool Equals(IdentityPart src)
            => api.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(IdentityPart other)
            => api.compare(this, other);

        public override string ToString()
            => Identifier;

        public override int GetHashCode()
            => api.hash(this);

        public override bool Equals(object obj)
            => api.equals(this, obj);
    }
}