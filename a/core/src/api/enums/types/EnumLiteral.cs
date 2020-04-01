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
    /// Appropriately defines an enumeration literal as the triple (index,name,value)
    /// </summary>
    /// <remarks>
    /// Here, index := declaration order of a declared literal, 
    /// name := user-defiend literal identifer, and
    /// value := the numeric content of the enum. 
    /// Defining a literal this way attempts to overcome troublesome aspects in which C#/clr enums 
    /// are implemented and preserves all enum information content. It is value-invariant in the sense 
    /// that the numeric content of does of a member not impact the n index/name content. 
    /// Thus, enum value duplication isn't an issue since all data are preserved, the api end-user can decide what
    /// value duplication means in a given context
    /// </remarks>
    public readonly struct EnumLiteral<E> : IFormattable<EnumLiteral<E>>
        where E : unmanaged, Enum        
    {
        public readonly int Index;

        public readonly string Name;

        public readonly E Value;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiteral<E>((int index, string name, E value) src)
            => new EnumLiteral<E>(src.index, src.name, src.value);
            
        [MethodImpl(Inline)]
        internal EnumLiteral(int index, string identifier, E value)
        {
            this.Name = identifier;
            this.Index = index;
            this.Value = value;
        }           

        [MethodImpl(Inline)]
        public void Deconstruct(out int index, out string name, out E value)
        {
            index = Index;
            name = Name;
            value = Value;
        }

        public override int GetHashCode()
            => Index;
        
        public string Format()
            => $"{Index.ToString().PadLeft(2, '0')} {Value}:{Name}";

        public override string ToString()
            => Format();            
    }
}