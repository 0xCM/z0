//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ToolDescription
    {
        public string ToolName {get;}

        public string Delimiter {get;}

        public ToolOptions Options {get;}
    }

    public readonly struct ToolDescription<K>
        where K : unmanaged
    {
        public string ToolName {get;}

        public string Delimiter {get;}

        public ToolOptions<K> Options {get;}
    }
}
