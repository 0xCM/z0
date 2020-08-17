//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static FS;

    partial struct FS
    {
        public readonly struct Tool : ITool<Tool>
        {
            public FS.FileName Name {get;}        
        }
    }
}