//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolArchive
    {
        /// <summary>
        /// The identifier of the owning tool
        /// </summary>
        ToolId ToolId {get;}

        /// <summary>
        /// The tool output directory
        /// </summary>
        FS.FolderPath ToolOutput {get;}

        /// <summary>
        /// The process root folder
        /// </summary>
        FS.FolderPath Processed {get;}
    }

    [Free]
    public interface IToolArchive<T> : IToolArchive
        where T : struct, ITool<T>
    {
        /// <summary>
        /// The tool that owns the archive
        /// </summary>
        T Owner => default(T);

        CmdOutput<T> Dir()
            => Tooling.output(this).Map(f => new CmdTarget<T>(f));
    }
}