//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Events)]

namespace Z0.Parts
{
    public sealed class Events : Part<Events>
    {

    }
}

namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    [ApiHost]
    public static partial class XTend
    {
    }

    [ApiHost]
    public static partial class XSvc
    {
        public static IWfDb SvcDb(IServiceContext context)
            => Z0.SvcDb.create(context);

        public static IWfDb SvcDb(IServiceContext context, FS.FolderPath root)
            => Z0.SvcDb.create(context).Relocate(root);
    }

    partial struct Msg
    {
        public static MsgPattern<ToolId> ToolHelpNotFound => "Tool {0} help not found";

        public static MsgPattern<Assembly,utf8> NoMatchingResources => "No {0} resources found that match {1}";

        public static MsgPattern<FS.FileUri> EmittingFile => "Emitting {0}";

        public static MsgPattern<FS.FileUri> EmittedFile => "Emitted {0}";

        public static MsgPattern<TableId,FS.FileUri> EmittingTable => "Emitting {0} to {1}";

        public static MsgPattern<TableId,Count,FS.FileUri> EmittedTable => "Emitted {1} {0} rows to {2}";
    }
}