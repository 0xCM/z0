//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TabularField : ITextual
    {
        public readonly string Name;

        public readonly int Index;

        public readonly int Width;
        
        [MethodImpl(Inline)]
        public static TabularField Define(string name, int index, int width)
            => new TabularField(name,index, width);
       
        [MethodImpl(Inline)]
        internal TabularField(string name, int index, int width)
        {
            Name = name;
            Index = index;
            Width = width;
        }   
        
        public string Format()
            => String.Concat($"{Index}".PadLeft(2,'0'), Chars.Space, $"{Width}".PadLeft(2,'0'), Chars.Space, Name);

        public override string ToString()
            => Format();     
    }
}