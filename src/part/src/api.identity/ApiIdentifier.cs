//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiIdentifier : IEquatable<ApiIdentifier>
    {
        public static ApiIdentifier create(in OpIdentity src)
            => new ApiIdentifier(LegalIdentityBuilder.code(src));

        public Identifier Name {get;}

        [MethodImpl(Inline)]
        ApiIdentifier(string src)
            => Name = src;

        [MethodImpl(Inline)]
        public string Format()
            => Name;

        [MethodImpl(Inline)]
        public bool Equals(ApiIdentifier src)
            => Name.Equals(src.Name);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Name.GetHashCode();

        public override bool Equals(object src)
            => src is ApiIdentifier x && Equals(x);
   }
}