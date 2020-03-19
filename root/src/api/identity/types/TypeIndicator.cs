//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Along with the associated kind, partitions numberic types into three parts: signed, unsigned and float
    /// </summary>
    public readonly struct TypeIndicator : IFormattable<TypeIndicator>
    {
        public readonly char Indication;

        public readonly bool IsEmpty;

        public static TypeIndicator Empty = Define(null);
                
        [MethodImpl(Inline)]
        public static TypeIndicator Define(char? c)
            => new TypeIndicator(c);
            
        [MethodImpl(Inline)]
        public static implicit operator string(TypeIndicator src)
            => src.ToString();

        [MethodImpl(Inline)]
        TypeIndicator(char? c)
        {
            this.IsEmpty = c == null;
            this.Indication = c ?? 'x';
        }
        
        public string Format()
            => IsEmpty ? string.Empty : Indication.ToString();        

        public override string ToString()
            => Format();
    }
}