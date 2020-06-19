//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DelegateIdentity : IIdentifiedType<DelegateIdentity>
    {
        public static DelegateIdentity Empty => Define(string.Empty, string.Empty, false, Control.array<TypeIdentity>());

        /// <summary>
        /// The type parameters that define the full delegate signature that includes the return type
        /// as the last identity in the array
        /// </summary>
        public TypeIdentity[] Parameters {get;}

        /// <summary>
        /// The unadorned name of the delegate tyepe
        /// </summary>
        public string DelegateName {get;}

        /// <summary>
        /// The identifier computed from the name and parameter identities
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// Indicates whether identifier should be rendered with a generic marker
        /// </summary>
        public bool Generic {get;}

        [MethodImpl(Inline)]
        public static DelegateIdentity Define(string identity, string name, bool generic, TypeIdentity[] parameters)
            => new DelegateIdentity(identity, name, generic,  parameters);

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
        DelegateIdentity(string identifier, string name, bool generic, TypeIdentity[] parameters)
        {
            Identifier = identifier;
            DelegateName = name;
            Parameters = parameters;
            Generic = generic;
        }

        IIdentifiedType<DelegateIdentity> Identified => this;
        
        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();
    }
}