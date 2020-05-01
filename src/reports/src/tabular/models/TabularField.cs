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

    public readonly struct TabularField : ITextual
    {
        public readonly string Name;

        public readonly int Index;

        public readonly int Width;
       
        [MethodImpl(Inline)]
        internal TabularField(string name, int index, int width)
        {
            this.Name = name;
            this.Index = index;
            this.Width = width;
        }   
        
        public string Format()
            => String.Concat($"{Index}".PadLeft(2,'0'), Chars.Space, $"{Width}".PadLeft(2,'0'), Chars.Space, Name);

        public override string ToString()
            => Format();     
    }
}