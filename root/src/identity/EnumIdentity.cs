//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct EnumIdentity  : ITypeIdentity<EnumIdentity>
    {
        public static EnumIdentity Empty = Define(string.Empty, NumericKind.None);

        [MethodImpl(Inline)]
        public static EnumIdentity From(Type src)
            => src.IsEnum ? Define(src.Name, src.GetEnumUnderlyingType().NumericKind()) : Empty;
                 
        [MethodImpl(Inline)]
        public static EnumIdentity Define(string name, NumericKind basetype)
            => new EnumIdentity(name, basetype);

        [MethodImpl(Inline)]
        public static implicit operator string(EnumIdentity src)
            => src.Identifier;

        [MethodImpl(Inline)]
        public static implicit operator TypeIdentity(EnumIdentity src)
            => src.AsTypeIdentity();

        [MethodImpl(Inline)]
        public static bool operator==(EnumIdentity a, EnumIdentity b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(EnumIdentity a, EnumIdentity b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        EnumIdentity(string name, NumericKind basetype)
        {
            this.Name = name;
            this.BaseType = basetype;
            this.Identifier = basetype.IsSome() ? $"{Name}{IDI.ModSep}{basetype.Format()}" : string.Empty;
        }
     
        public string Identifier {get;}            

        public string Name {get;}
        
        public NumericKind BaseType {get;}           

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => string.IsNullOrWhiteSpace(Identifier);
        }

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        [MethodImpl(Inline)]
        public bool Equals(EnumIdentity src)
            => IdentityCommons.IdentityEquals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(IIdentity other)
            => IdentityCommons.IdentityCompare(this, other);
 
        public override int GetHashCode()
            => IdentityCommons.IdentityHashCode(this);

        public override bool Equals(object obj)
            => IdentityCommons.IdentityEquals(this, obj);

        public override string ToString()
            => Identifier;

    }
}