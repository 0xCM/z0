//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static ToolFolderNames;

    public readonly struct ToolFolders
    {
        public static FS.FolderName Input => FS.folder(input);

        public static FS.FolderName Output => FS.folder(output);

        public static FS.FolderName Processed => FS.folder(processed);
    }
}