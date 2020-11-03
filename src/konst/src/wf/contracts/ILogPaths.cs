//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static CoreFolderNames;

    public interface ILogPaths
    {
        /// <summary>
        /// The global application log root
        /// </summary>
        FS.FolderPath RuntimeLogs {get;}

        /// <summary>
        /// The global application log root
        /// </summary>
        FS.FolderPath RuntimeData {get;}

        /// <summary>
        /// The name of the runtime log folder
        /// </summary>
        FS.FolderName AppLogFolder
            => FS.folder(AppsFolder);

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();
    }
}