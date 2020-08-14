//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    [Table]
    public struct MemoryFileInfo
    {
        public MemoryAddress BaseAddress;

        public FileDescription Description;    
    }
}