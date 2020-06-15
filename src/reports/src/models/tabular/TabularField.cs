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
        public TabularField(string name, int index, int width)
        {
            Name = name;
            Index = index;
            Width = width;
        }           
        public string Format()
            => text.concat($"{Index}".PadLeft(2,'0'), Space, $"{Width}".PadLeft(2,'0'), Space, Name);

        public override string ToString()
            => Format();     
    }
}