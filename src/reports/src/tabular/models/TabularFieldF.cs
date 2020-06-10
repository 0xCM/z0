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
    /// Specifies salient characteristics of a tabular field predicated
    /// on an enumeration value
    /// </summary>
    public readonly struct TabularField<F> : ITextual
        where F : unmanaged, Enum        
    {
        /// <summary>
        /// The field specifier
        /// </summary>
        public readonly F Specifier;

        /// <summary>
        /// The field name
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The 0-based field index
        /// </summary>
        public readonly int Index;

        /// <summary>
        /// The field width
        /// </summary>
        public readonly int Width;
              
        [MethodImpl(Inline)]
        internal TabularField(F spec)
        {
            var numeric = Enums.e64u(spec);
            this.Specifier = spec;
            this.Name = spec.ToString();
            this.Index = (int)(Tabular.PosMask & numeric);
            this.Width = (int)(numeric >> Tabular.WidthOffset);
        }   
        
        public string Format()
            => String.Concat($"{Index}".PadLeft(2,'0'), Chars.Space, $"{Width}".PadLeft(2,'0'), Chars.Space, Name);

        public override string ToString()
            => Format();     
    }
}