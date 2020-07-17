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
    /// Defines a boxed enumeration literal as the triple (index,identifier,value)
    /// </summary>
    public readonly struct EnumLiteral : IEnumLiteral<EnumLiteral>
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
        /// The literal value
        /// </summary>
        public variant ScalarValue {get;}

        /// <summary>
        /// The enum's numeric data type
        /// </summary>
        public NumericKind DataType {get;}

        /// <summary>
        /// The metadata token that identifies the backing field
        /// </summary>
        public ArtifactIdentity Id 
        {
            [MethodImpl(Inline)]
            get => BackingField.MetadataToken;
        }

        [MethodImpl(Inline)]
        public EnumLiteral(FieldInfo field, NumericKind kind, uint index, string identifier, variant value)
        {
            BackingField = field;
            Name = identifier;
            DataType = kind;
            Position = index;
            ScalarValue = value;
        }           

        [MethodImpl(Inline)]
        public bool Equals(EnumLiteral src)
            => Position == src.Position 
            && Name == src.Name 
            && ScalarValue.Equals(src.ScalarValue);

        public override bool Equals(object src)
            => src is EnumLiteral x && Equals(x);

        public override int GetHashCode()
            => (int)Position;
        
        public override string ToString()
            => (this as IEnumLiteral).Format();            
    }
}