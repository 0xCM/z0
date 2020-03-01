//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static IdentityOps;

    public readonly struct EnumIdentity  : ITypeIdentity<EnumIdentity>
    {
        public static EnumIdentity Empty = Define(string.Empty, NumericKind.None);

        public string Identifier {get;}            

        public string Name {get;}
        
        public NumericKind BaseType {get;}           

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
     
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Identifier);
        }

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier);

        [MethodImpl(Inline)]
        public bool Equals(EnumIdentity src)
            => IdentityOps.equals(this, src);

        [MethodImpl(Inline)]
        public int CompareTo(EnumIdentity src)
            => compare(this, src);
 
        public override int GetHashCode()
            => hash(this);

        public override bool Equals(object obj)
            => equals(this, obj);

        public override string ToString()
            => Identifier;
    }
}