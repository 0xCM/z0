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
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public int Index {get;}

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public string Identifier {get;}

        /// <summary>
        /// The literal E-value
        /// </summary>
        public E LiteralValue  {get;}

        [MethodImpl(Inline)]
        public static implicit operator EnumLiteral<E>((int index, string name, E value) src)
            => new EnumLiteral<E>(src.index, src.name, src.value);
            
        [MethodImpl(Inline)]
        internal EnumLiteral(int index, string identifier, E value)
        {
            this.Identifier = identifier;
            this.Index = index;
            this.LiteralValue = value;
        }           

        [MethodImpl(Inline)]
        public bool Equals(EnumLiteral<E> src)
            => Index == src.Index 
            && Identifier == src.Identifier 
            && LiteralValue.Equals(src.LiteralValue);

        public override bool Equals(object src)
            => src is EnumLiteral<E> x && Equals(x);

        public override int GetHashCode()
            => Index;
        
        public override string ToString()
            => (this as IEnumLiteral).Format();            
    }
}