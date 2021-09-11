//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    public sealed class ToolWs : IWorkspace<ToolWs>
    {
        [MethodImpl(Inline)]
        public static ToolWs create(FS.FolderPath root)
            => new ToolWs(root);

        public FS.FolderPath Root {get;}

        Dictionary<ToolId,ToolConfig> ConfigLookup;

        internal ToolWs(FS.FolderPath root)
        {
            Root = root;
            ConfigLookup = dict<ToolId,ToolConfig>();
        }

        public bool Settings(ToolId id, out ToolConfig dst)
            => ConfigLookup.TryGetValue(id, out dst);

        public void Configure(ToolId id, in ToolConfig src)
            => ConfigLookup[id] = src;
    }
}