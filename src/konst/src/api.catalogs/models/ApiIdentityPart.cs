//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = ApiIdentity;

    /// <summary>
    /// Defines an identity component
    /// </summary>
    public readonly struct ApiIdentityPart : IIdentification<ApiIdentityPart>
    {
        public readonly byte Index;

        public readonly ApiIdentityPartKind Kind;

        public string Identifier {get;}

        public ApiIdentityPart(byte index, ApiIdentityPartKind kind, string text)
        {
            Index = index;
            Kind = kind;
            Identifier = text;
        }

        public bool IsName
            => Kind == ApiIdentityPartKind.Name;

        public bool IsSuffix
            => Kind == ApiIdentityPartKind.Suffix;

        public bool IsNumeric
            => Kind == ApiIdentityPartKind.Numeric;

        public bool IsSegment
            => Kind == ApiIdentityPartKind.Segment;

        public ApiIdentityPart WithText(string src)
            => new ApiIdentityPart(Index, Kind, src);

        [MethodImpl(Inline)]
        public bool Equals(ApiIdentityPart src)
            => api.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(ApiIdentityPart other)
            => api.compare(this, other);

        public override string ToString()
            => Identifier;

        public override int GetHashCode()
            => api.hash(this);

        public override bool Equals(object obj)
            => api.equals(this, obj);

        [MethodImpl(Inline)]
        public static implicit operator ApiIdentityPart((byte index, ApiIdentityPartKind kind, string text) src)
            => new ApiIdentityPart(src.index, src.kind, src.text);

        [MethodImpl(Inline)]
        public static implicit operator string(ApiIdentityPart src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(ApiIdentityPart a, ApiIdentityPart b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiIdentityPart a, ApiIdentityPart b)
            => !a.Equals(b);
    }
}