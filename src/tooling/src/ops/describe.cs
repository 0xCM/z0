//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    partial struct ToolCmd
    {
        /// <summary>
        /// Derives a <see cref='ToolInfo'/> from a specifying record
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static ToolInfo toolinfo(ToolId id, string description, string group, FS.FilePath path)
        {
            var dst = new ToolInfo();
            dst.ToolId = id;
            dst.Descripion = description;
            dst.GroupName = group;
            dst.PhysicalPath = path;
            dst.VirtualPath = FS.FilePath.Empty;
            dst.ShimPath = FS.FilePath.Empty;
            return dst;
        }
    }
}