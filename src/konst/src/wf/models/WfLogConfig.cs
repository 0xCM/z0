//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct WfLogConfig : ITextual
    {
        public PartId Control;

        public FS.FolderPath Root;

        public FS.FilePath StatusLog;

        public FS.FilePath ErrorLog;

        [MethodImpl(Inline)]
        public WfLogConfig(PartId control, FS.FolderPath root, PartId? part = null)
        {
            Control = control;
            Root = root;
            StatusLog = FS.path(text.format("{0}/{1}.status.csv", root, Control.Format()));
            ErrorLog = FS.path(text.format("{0}/{1}.errors.csv", root, Control.Format()));
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(Root, StatusLog, ErrorLog);
    }
}