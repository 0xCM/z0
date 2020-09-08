//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FS;

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

        [MethodImpl(Inline)]
        public WfLogConfig(PartId control, FS.FolderPath root)
        {
            Control = control;
            Root = root;
            var app = Control.Format();
            StatusLog = root + FS.file(app, FS.Extensions.StatusLog);
            ErrorLog = root + FS.file(app, FS.Extensions.ErrorLog);
            //StatusLog = FS.path(text.format("{0}/{1}.status.log", root, Control.Format()));
            //ErrorLog = FS.path(text.format("{0}/{1}.errors.log", root, Control.Format()));
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(Root, StatusLog, ErrorLog);
    }
}