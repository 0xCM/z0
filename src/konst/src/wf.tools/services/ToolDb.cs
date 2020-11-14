//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolDb : IToolDb<ToolDb>
    {
        public FS.FolderPath Storage {get;}

        [MethodImpl(Inline)]
        public ToolDb(FS.FolderPath storage)
        {
            Storage = storage;
        }
    }
}