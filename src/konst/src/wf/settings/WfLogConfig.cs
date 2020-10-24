//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using X = ArchiveFileKinds;

    public struct WfLogConfig : ITextual
    {
        /// <summary>
        /// The controlling part identifier
        /// </summary>
        public PartId Control;

        /// <summary>
        /// The log file root directory
        /// </summary>
        public FS.FolderPath Root;

        /// <summary>
        /// The status log path
        /// </summary>
        public FS.FilePath StatusLog;

        /// <summary>
        /// The error log path
        /// </summary>
        public FS.FilePath ErrorLog;

        /// <summary>
        /// The location to which completed logs are published
        /// </summary>
        public FS.FolderPath DbRoot;

        [MethodImpl(Inline)]
        public WfLogConfig(PartId control, FS.FolderPath root, FS.FolderPath dbRoot)
        {
            Control = control;
            Root = root;
            var app = Control.Format();
            StatusLog = Root + FS.file(app, X.StatusLog);
            ErrorLog = Root + FS.file(app, X.ErrorLog);
            DbRoot = dbRoot;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(Root, StatusLog, ErrorLog, DbRoot);

        public override string ToString()
            => Format();
    }
}