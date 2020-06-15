//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;

    /// <summary>
    /// Defines an E-V parametric enum value
    /// </summary>
    public readonly struct EnumLiteral<E,V> : IEnumLiteral<EnumLiteral<E, V>, E, V>
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
        public int Index 
        {
            [MethodImpl(Inline)]
            get => Literal.Index;
        }

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public string Identifier
        {
            [MethodImpl(Inline)]
            get => Literal.Identifier;
        }

        /// <summary>
        /// The literal E-value
        /// </summary>
        public E LiteralValue 
        {
            [MethodImpl(Inline)]
            get => Literal.LiteralValue;
        }

        /// <summary>
        /// The numeric kind refined by the enum
        /// </summary>
        public EnumScalarKind DataType 
        {
            [MethodImpl(Inline)]
            get => Enums.@base<E>();
        }

        public MetadataToken Token
        {
            [MethodImpl(Inline)]
            get => Literal.Token;
        }

        public FieldInfo Field
        {
            [MethodImpl(Inline)]
            get => Literal.Field;
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

        ulong IEnumLiteral.LiteralValue 
            => Enums.untype(LiteralValue);

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
            => Index;

        public override string ToString()
            => (this as IEnumLiteral).Format();            
    }
}