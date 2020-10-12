//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolSettings
    {
        public string ToolName;

        public FS.FolderPath InputRoot;

        public FS.FolderPath OutputRoot;

        public FS.FolderPath ProcessedRoot;
    }
}