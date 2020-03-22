//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityShare;

    public readonly struct DelegateIdentity : IIdentifiedType<DelegateIdentity>
    {
        public string Identifier {get;}

        public static DelegateIdentity Empty => Define(string.Empty);

        [MethodImpl(Inline)]
        public static DelegateIdentity Define(string identifier)
            => new DelegateIdentity(identifier);

        [MethodImpl(Inline)]
        public static implicit operator string(DelegateIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static bool operator==(DelegateIdentity a, DelegateIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(DelegateIdentity a, DelegateIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        DelegateIdentity(string id)
            => Identifier = id;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Identifier);
        }

        [MethodImpl(Inline)]
        public bool Equals(DelegateIdentity src)
            => equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(DelegateIdentity src)
            => compare(this, src); 

        public string Format()
            => IdentityShare.format(this);

        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Format();
    }
}