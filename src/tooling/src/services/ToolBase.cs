//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed partial class ToolBase : Service<ToolBase>
    {
        const string config = nameof(config);

        const string docs = nameof(docs);

        const string logs = nameof(logs);

        const string scripts = nameof(scripts);

        const string samples = nameof(samples);

        public FS.FolderPath Root {get; private set;}

        Index<ToolConfig> _Tools;

        uint ToolCount;

        uint Capacity;


        public ToolBase()
        {
            Capacity = 1024;
            _Tools = alloc<ToolConfig>(Capacity);
            ToolCount = 0;
        }

        [MethodImpl(Inline)]
        public ToolBase Configure(FS.FolderPath root)
        {
            Root = root;
            return this;
        }

        public FS.FolderPath Home(ToolId tool)
            => Root + FS.folder(tool.Format());

        public FS.FolderPath Docs(ToolId tool)
            => Home(tool) + FS.folder(docs);

        public FS.FolderPath Logs(ToolId tool)
            => Home(tool) + FS.folder(logs);

        public FS.FolderPath Scripts(ToolId tool)
            => Home(tool) + FS.folder(scripts);

        public FS.FolderPath Samples(ToolId tool)
            => Home(tool) + FS.folder(samples);

        public FS.FilePath Script(ToolId tool, string id)
            => Scripts(tool) + FS.file(id,FS.Cmd);

        public FS.FilePath ConfigScript(ToolId tool)
            => Home(tool) + FS.file(config, FS.Cmd);

        public FS.FilePath ConfigLog(ToolId tool)
            => Logs(tool) + FS.file(config, FS.Log);
    }
}