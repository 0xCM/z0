//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Defines an E-V parametric enum value
    /// </summary>
    public readonly struct EnumLiteral<E,V> : IEnumLiteral<EnumLiteral<E,V>,E,V>
        where E : unmanaged, Enum
        where V : unmanaged
    {        
        readonly EnumLiteral<E> Literal;

        /// <summary>
        /// The literal V-value
        /// </summary>
        public V NumericValue {get;}

        /// <summary>
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public uint Position 
        {
            [MethodImpl(Inline)]
            get => Literal.Position;
        }

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public string Name
        {
            [MethodImpl(Inline)]
            get => Literal.Name;
        }

        /// <summary>
        /// The literal E-value
        /// </summary>
        public E LiteralValue 
        {
            [MethodImpl(Inline)]
            get => Literal.LiteralValue;
        }

        variant IEnumLiteral.ScalarValue
        {
            [MethodImpl(Inline)]
            get => Variant.from(Literal.LiteralValue);
        }

        /// <summary>
        /// The numeric kind refined by the enum
        /// </summary>
        public EnumScalarKind PrimalKind 
        {
            [MethodImpl(Inline)]
            get => Enums.@base<E>();
        }

        public ArtifactIdentity Token
        {
            [MethodImpl(Inline)]
            get => Literal.Id;
        }

        public FieldInfo Field
        {
            [MethodImpl(Inline)]
            get => Literal.BackingField;
        }

        public NumericKind DataType 
        {
            [MethodImpl(Inline)]
            get => NumericKinds.kind<V>();
        }

        public string Description
        {
            [MethodImpl(Inline)]
            get => Literal.Description;
        }

        public UserMetadata UserData
        {
            [MethodImpl(Inline)]
            get => Literal.UserData;
        }

        [MethodImpl(Inline)]
        internal EnumLiteral(EnumLiteral<E> literal, V v)
        {
            this.Literal = literal;
            this.NumericValue = v;    
        }

        [MethodImpl(Inline)]
        public bool Equals(EnumLiteral<E,V> src)
            => Literal.Equals(src.Literal) 
            && NumericValue.Equals(src.NumericValue);


        public override bool Equals(object src)
            => src is EnumLiteral<E,V> x && Equals(x);
        
        public override int GetHashCode()
            => (int)Position;

        public override string ToString()
            => (this as IEnumLiteral).Format();            
    }
}