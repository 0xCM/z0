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

    public sealed class ToolWs : IToolWs, IWorkspace<ToolWs>
    {
        [MethodImpl(Inline)]
        public static ToolWs create(FS.FolderPath root)
            => new ToolWs(root);

        public FS.FolderPath Root {get; private set;}

        Dictionary<ToolId,ToolConfig> ConfigLookup;

        public ToolWs(FS.FolderPath root)
        {
            Root = root;
            ConfigLookup = dict<ToolId,ToolConfig>();
        }

        public bool Settings(ToolId id, out ToolConfig dst)
            => ConfigLookup.TryGetValue(id, out dst);

        public void Configure(ToolId id, in ToolConfig src)
            => ConfigLookup[id] = src;

        public FS.FolderPath WsRoot()
        {
            return Root;
        }

        public FS.FolderPath WsRoot(FS.FolderPath src)
        {
            Root = src;
            return WsRoot();
        }
    }
}