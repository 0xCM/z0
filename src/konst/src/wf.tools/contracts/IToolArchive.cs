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
    public interface IToolArchive : IIdentified<CmdHostId>, IFileArchive
    {
        CmdHostId ToolId {get;}

        ToolArchiveKind ArchiveKind {get;}

        CmdHostId IIdentified<CmdHostId>.Id
            => ToolId;
    }

    [Free]
    public interface IToolArchive<T> : IToolArchive, IFileArchive<ToolArchiveKind>
        where T : struct, ITool<T>
    {

    }
}