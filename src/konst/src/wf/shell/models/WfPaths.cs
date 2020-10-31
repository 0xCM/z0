//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Reifies default application path service
    /// </summary>
    public readonly struct WfPaths : IWfPaths
    {
        public FS.FolderPath RuntimeLogs {get;}

        public FS.FolderPath RuntimeData {get;}

        public FS.FolderPath DbRoot {get;}

        public WfPaths(WfLogConfig logs)
        {
            RuntimeData = logs.Root;
            RuntimeLogs = RuntimeData;
            DbRoot = logs.DbRoot;
        }

        public WfPaths(FS.FolderPath logs, FS.FolderPath data,  FS.FolderPath db)
        {
            RuntimeLogs = logs;
            RuntimeData = data;
            DbRoot = db;
        }
    }
}