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
    /// Defines an enumeration literal as the triple (index,identifier,value)
    /// </summary>
    /// <remarks>
    /// Defining a literal this way attempts to overcome troublesome aspects in which C#/clr enums 
    /// are implemented and preserves all enum information content. It is value-invariant in the sense 
    /// that the numeric content of does of a member not impact the n index/name content. 
    /// Thus, enum value duplication isn't an issue since all data are preserved, the api end-user can decide what
    /// value duplication means in a given context
    /// </remarks>
    public readonly struct EnumLiteral<E> : IEnumLiteral<EnumLiteral<E>, E>
        where E : unmanaged, Enum        
    {
        /// <summary>
        /// The compiler-emitted field that defines the literal
        /// </summary>
        public FieldInfo BackingField {get;}
        
        /// <summary>
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public uint Position {get;}

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The literal E-value
        /// </summary>
        public E LiteralValue  {get;}

        /// <summary>
        /// The enum's numeric data type
        /// </summary>
        public NumericKind DataType {get;}

        /// <summary>
        /// The meaning of the literal, if available
        /// </summary>
        public string Description {get;}

        /// <summary>
        /// User data attched to the literal, if any
        /// </summary>
        public UserMetadata UserData {get;}

        /// <summary>
        /// The metadata token that identifies the backing field
        /// </summary>
        public ArtifactIdentity Id 
        {
            [MethodImpl(Inline)]
            get => BackingField;
        }

        variant IEnumLiteral.ScalarValue            
            => Variant.define(LiteralValue, DataType);
        
        [MethodImpl(Inline)]
        internal EnumLiteral(FieldInfo field, EnumScalarKind type, uint index, string identifier, E value, string description, UserMetadata data)
        {
            BackingField = field;
            DataType = typeof(E).GetEnumUnderlyingType().NumericKind();
            Name = identifier;
            Position = index;
            LiteralValue = value;
            Description = description;
            UserData = data;
        }           

        [MethodImpl(Inline)]
        public bool Equals(EnumLiteral<E> src)
            => Id == src.Id
            && Position == src.Position 
            && Name == src.Name 
            && LiteralValue.Equals(src.LiteralValue);

        public override bool Equals(object src)
            => src is EnumLiteral<E> x && Equals(x);

        public override int GetHashCode()
            => (int)Position;
        
        public override string ToString()
            => (this as IEnumLiteral).Format();            
    }
}