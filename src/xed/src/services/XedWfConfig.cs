//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct XedWfConfig
    {
        public XedWfConfig(IWfRuntime wf)
        {
            var db = wf.Db();
            Source = db.DataSourceDir("xed");
            Target = db.TableDir("xed");
        }

        public FS.FileName SummaryFile
            => FS.file(text.format("{0}.{1}", "xed", "summary"), DataFileExt);

        public FS.FolderPath Source {get;}

        public FS.FolderPath Target {get;}

        public FS.FolderName ExtensionFolder
            => FS.folder("extensions");

        public FS.FolderName CategoryFolder
            => FS.folder("categories");

        public FS.FolderName InstructionFolder
            => FS.folder("instructions");

        public FS.FolderPath InstructionDir
            => Target + InstructionFolder;

        public FS.FileExt DataFileExt
            => FS.Csv;
    }
}