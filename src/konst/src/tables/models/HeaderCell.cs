//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HeaderCell
    {
        public readonly uint Index;        

        public readonly string Name;

        public readonly RenderWidth Width;

        [MethodImpl(Inline)]
        public HeaderCell(uint index, string name, RenderWidth width)
        {
            Index = index;
            Name = name;
            Width = width;
        }
    }
}