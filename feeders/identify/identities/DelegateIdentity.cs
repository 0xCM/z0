//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Identify;

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

        IIdentifiedType<DelegateIdentity> Identified => this;

        
        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();
    }
}