//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Data;

    public readonly struct ListedFile : ITable<ListedFileField, ListedFile>
    {
        public readonly uint Index;
        
        public readonly string Path;

        [MethodImpl(Inline)]
        public ListedFile(uint index, string path)
        {
            Index = index;
            Path = path;
        }        
    }
}