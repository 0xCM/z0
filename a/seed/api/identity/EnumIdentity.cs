//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct EnumIdentity : IIdentifiedType<EnumIdentity>
    {
        public static EnumIdentity Empty = Define(string.Empty, NumericKind.None);

        public string Identifier {get;}            

        public string Name {get;}
        
        public NumericKind BaseType {get;}           

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
            this.Identifier = basetype != 0 ? $"{Name}{IDI.ModSep}{basetype.Format()}" : string.Empty;
        }
     
        IIdentifiedType<EnumIdentity> Identified => this;
        
        public override int GetHashCode()
            => Identified.HashCode;

        public override bool Equals(object obj)
            => Identified.Same(obj);

        public override string ToString()
            => Identified.Format();

        [MethodImpl(Inline)]
        public TypeIdentity AsTypeIdentity()
            => TypeIdentity.Define(Identifier); 
    }
}