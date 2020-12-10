//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    /// <summary>
    /// Represents a toolset distribution
    /// </summary>
    public readonly struct ToolsetDist : IToolsetDist<ToolsetDist>
    {
        public FS.FolderPath Root {get;}

        public ToolId ToolsetId {get;}

        public Index<ToolId> Tools {get;}
    }
}