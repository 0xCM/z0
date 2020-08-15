//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolIndexEntries : ITableSpan<ToolIndexEntry>
    {
        public readonly TableSpan<ToolIndexEntry> Data;       

        public ToolIndexEntry[] Storage 
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }
        
        [MethodImpl(Inline)]
        public ToolIndexEntries(ToolIndexEntry[] src)
            => Data = src;    
    }
}