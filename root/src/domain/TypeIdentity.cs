//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public readonly struct TypeIdentity : IIdentity<TypeIdentity>
    {
        public string Identifier {get;}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TypeIdentity Define(string identifier)
            => new TypeIdentity(identifier);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator string(TypeIdentity src)
            => src.Identifier;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TypeIdentity operator +(TypeIdentity lhs, string rhs)
            => Define($"{lhs}{rhs}");

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TypeIdentity operator +(string lhs, TypeIdentity rhs)
            => Define($"{lhs}{rhs}");

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator==(TypeIdentity a, TypeIdentity b)
            => a.Equals(b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator!=(TypeIdentity a, TypeIdentity b)
            => !a.Equals(b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        TypeIdentity(string id)
            => Identifier = id;

        public override string ToString()
            => Identifier;
        
        public override int GetHashCode()
            => Identifier.GetHashCode();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(TypeIdentity src)
            => string.Equals(src.Identifier, Identifier, StringComparison.InvariantCultureIgnoreCase);

        public override bool Equals(object obj)
            => obj is TypeIdentity id && Equals(id);

       public const char SegSep = 'x';

    }
}