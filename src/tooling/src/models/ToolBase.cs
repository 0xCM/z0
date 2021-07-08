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
        internal ToolBase Configure(CharBlock16 name, FS.FolderPath root)
        {
            Name = name;
            Root = root;
            return this;
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