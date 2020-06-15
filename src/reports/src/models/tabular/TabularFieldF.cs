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
            var numeric = Enums.e32u(spec);
            this.Specifier = spec;
            this.Name = spec.ToString();
            this.Index = Tabular.index(spec);
            this.Width = text.width(spec);
        }   

        [MethodImpl(Inline)]
        public TabularField(F spec, string name, int index, int width)
        {            
            Specifier = spec;
            Name = name;
            Index = index;
            Width = width;
        }   
        public string Format()
            => String.Concat($"{Index}".PadLeft(2,'0'), Space, $"{Width}".PadLeft(2,'0'), Space, Name);

        public override string ToString()
            => Format();     
    }
}