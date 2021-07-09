//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;
    using static core;

    public sealed class ToolBase : Service<ToolBase>
    {
        public FS.FolderPath Root {get; private set;}

        Index<ToolInfo> _Tools;

        uint ToolCount;

        uint Capacity;

        public CharBlock16 Name {get; private set;}

        public ToolBase()
        {
            Capacity = 1024;
            _Tools = alloc<ToolInfo>(Capacity);
            ToolCount = 0;
        }

        [MethodImpl(Inline)]
        public ToolBase Configure(CharBlock16 name, FS.FolderPath root)
        {
            Name = name;
            Root = root;
            return this;
        }

        public FS.FolderPath ToolDir(ToolId tool)
            => Root + FS.folder(tool.Format());

        public FS.FolderPath ToolDocs(ToolId tool)
            => ToolDir(tool) + FS.folder("docs");

        public FS.FolderPath ToolBin(ToolId tool)
            => ToolDir(tool) + FS.folder("bin");

        public FS.FilePath ToolExe(ToolId tool)
            => ToolBin(tool) + FS.file(tool.Format(), FS.Exe);

        public FS.FilePath ToolCmd(ToolId tool)
            => ToolBin(tool) + FS.file(tool.Format(), FS.Cmd);

        public FS.FilePath HelpFile(ToolId tool)
        {
            var match = FS.file(tool.Format());
            return ToolDir(tool).Files(FS.ext("help")).Where(f => f.FileName.WithoutExtension.Equals(match)).FirstOrDefault();
        }

        public Outcome WithTool(in ToolInfo src)
        {
            var result = Outcome.Success;
            if(ToolCount < Capacity)
                _Tools[ToolCount++] = src;
            else
                result = (false, "Capacity exceeded");
            return result;
        }

        public ReadOnlySpan<ToolInfo> Tools
        {
            [MethodImpl(Inline)]
            get => _Tools.View;
        }
    }
}