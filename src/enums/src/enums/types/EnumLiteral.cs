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
        public FieldInfo Field {get;}

        /// <summary>
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public int Index {get;}

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The literal value
        /// </summary>
        public ulong LiteralValue {get;}

        /// <summary>
        /// The enum's numeric data type
        /// </summary>
        public EnumScalarKind DataType {get;}

        /// <summary>
        /// The metadata token that identifies the backing field
        /// </summary>
        public MetadataToken Token 
        {
            [MethodImpl(Inline)]
            get => Field;
        }

        [MethodImpl(Inline)]
        public EnumLiteral(FieldInfo field, int index, string identifier, EnumScalarKind type, ulong value)
        {
            Field = field;
            Identifier = identifier;
            DataType = type;
            Index = index;
            LiteralValue = value;
        }           

        [MethodImpl(Inline)]
        public bool Equals(EnumLiteral src)
            => Index == src.Index 
            && Identifier == src.Identifier 
            && LiteralValue.Equals(src.LiteralValue);

        public override bool Equals(object src)
            => src is EnumLiteral x && Equals(x);

        public override int GetHashCode()
            => Index;
        
        public override string ToString()
            => (this as IEnumLiteral).Format();            
    }
}