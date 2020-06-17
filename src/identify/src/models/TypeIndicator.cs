//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Partitions types into manageable pieces in various ways, hopefully sensible, with 16 bits
    /// </summary>
    public readonly struct TypeIndicator : ITextual
    {
        readonly char I;

        [MethodImpl(Inline)]
        public static TypeIndicator Define(char c)
            => new TypeIndicator(c);

        /// <summary>
        /// The nonindicating indicator
        /// </summary>
        public static TypeIndicator Empty = Define(Chars.D0);

        /// <summary>
        /// Identifies the signed numeric partition
        /// </summary>
        public static TypeIndicator Signed => IDI.Signed;

        /// <summary>
        /// Identifies the unsigned numeric partition
        /// </summary>
        public static TypeIndicator Unsigned => IDI.Unsigned;

        /// <summary>
        /// Identifies the floating-point numeric partition
        /// </summary>
        public static TypeIndicator Float => IDI.Float;
                                            
        /// <summary>
        /// Identifies the vectorized type partition
        /// </summary>
        public static TypeIndicator Vector => IDI.Vector;

        /// <summary>
        /// Identifies the block type partition
        /// </summary>
        public static TypeIndicator Block => IDI.Block;

        /// <summary>
        /// Identifies the generic type partition
        /// </summary>
        public static TypeIndicator Generic => IDI.Generic;

        [MethodImpl(Inline)]
        public static implicit operator string(TypeIndicator src)
            => src.ToString();

        [MethodImpl(Inline)]
        public static implicit operator TypeIndicator(char src)
            => new TypeIndicator(src);

        [MethodImpl(Inline)]
        TypeIndicator(char c)
        {
            I = c;
        }

        /// <summary>
        /// Specifies whether the indicator is non-indicating
        /// </summary>
        public bool IsEmpty 
            => I == Chars.D0;
       
        public string Format()
            => IsEmpty ? string.Empty : I.ToString();        

        public override string ToString()
            => Format();
    }
}