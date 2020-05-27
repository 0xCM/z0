//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a boxed enumeration literal as the triple (index,identifier,value)
    /// </summary>
    public readonly struct EnumLiteral : IEnumLiteral<EnumLiteral>
    {
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

        public NumericKind NumericKind {get;}
            
        [MethodImpl(Inline)]
        internal EnumLiteral(int index, string identifier, NumericKind kind, ulong value)
        {
            this.Identifier = identifier;
            this.NumericKind = kind;
            this.Index = index;
            this.LiteralValue = value;
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