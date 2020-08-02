//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableHeaderCell
    {
        public readonly uint Index;        

        public readonly string Label;
        
        [MethodImpl(Inline)]
        public TableHeaderCell(uint index, string label)
        {
            Index = index;
            Label = label;
        }
    }
}