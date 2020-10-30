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

    partial struct Tooling
    {
        [MethodImpl(Inline), Op]
        public static ref ToolSettings init(string tool, FS.FolderPath root, ref ToolSettings dst)
        {
            dst.ToolName = tool;
            dst.InputRoot = root + FS.folder(tool) + ToolFolders.Input;
            dst.OutputRoot = root + FS.folder(tool) + ToolFolders.Output;
            dst.ProcessedRoot = root + FS.folder(tool) + ToolFolders.Processed;
            return ref dst;
        }
    }
}