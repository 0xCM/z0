//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a tool-specific file archive
    /// </summary>
    [Free]
    public interface IToolWorkspace : IIdentified<ToolId>, IFileArchive
    {
        ToolId ToolId {get;}

        ToolArchiveKind ArchiveKind {get;}

        ToolId IIdentified<ToolId>.Id
            => ToolId;
    }

    [Free]
    public interface IToolWorkspace<T> : IToolWorkspace, IFileArchive
        where T : struct, ITool<T>
    {

    }
}