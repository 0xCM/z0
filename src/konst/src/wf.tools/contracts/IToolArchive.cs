//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolArchive : IIdentified<ToolId>
    {
        /// <summary>
        /// The tool output directory
        /// </summary>
        FS.FolderPath Target {get;}

        /// <summary>
        /// The process root folder
        /// </summary>
        FS.FolderPath Processed {get;}
    }

    [Free]
    public interface IToolArchive<T> : IToolArchive
        where T : struct, ITool<T>
    {
        ToolOutput<T> Dir()
            => Tooling.output(this).Map(Tooling.target<T>);
    }
}