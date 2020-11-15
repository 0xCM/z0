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
        const string FormatPattern = "{0}:{1} | {2}:{3} | {4}:{5} | {6}:{7}";

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

        public string Format()
            => string.Format(RP.Settings4,
                nameof(Root), Root.Format(),
                nameof(StatusLog), StatusLog.Format(),
                nameof(ErrorLog), ErrorLog.Format(),
                nameof(DbRoot), DbRoot.Format());

        public override string ToString()
            => Format();
    }
}