//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HeaderCell
    {
        public readonly uint Index;        

        public readonly string Label;
        
        [MethodImpl(Inline)]
        public HeaderCell(uint index, string label)
        {
            Index = index;
            Label = label;
        }
    }
}