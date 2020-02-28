//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ReportFieldInfo : IFormattable<ReportFieldInfo>
    {
        public readonly string Name;

        public readonly int Index;

        public readonly int Width;

        [MethodImpl(Inline)]
        public static ReportFieldInfo Define(string name, int index,  int width)
            => new ReportFieldInfo(name, index, width);
       
        [MethodImpl(Inline)]
        ReportFieldInfo(string name, int index, int width)
        {
            this.Name = name;
            this.Index = index;
            this.Width = width;
        }   

        public string Format()
            => text.concat($"{Index}".PadLeft(2,'0'), text.space(), $"{Width}".PadLeft(2,'0'), text.space(), Name);

        public override string ToString()
            => Format();     
    }
}