//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct XedWfConfig
    {
        public XedWfConfig(IWfRuntime wf)
        {
            var db = wf.Db();
            Source = db.ExternalDataDir("xed");
            Target = db.TableDir("xed");
        }

        public FS.FolderPath Source {get;}

        public FS.FolderPath Target {get;}

        public FS.FolderName InstructionFolder
            => FS.folder("instructions");

        public FS.FolderPath InstructionDir
            => Target + InstructionFolder;

        public FS.FileExt DataFileExt
            => FS.Csv;
    }
}