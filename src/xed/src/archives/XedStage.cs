//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public readonly struct XedStage : IPartFilePaths
    {
        public static XedStage Create(FS.FolderPath root)
            => new XedStage(root);

        public FS.FolderPath ArchiveRoot {get;}

        public FS.FolderName InstructionFolder
            => FS.folder("instructions");

        public FS.FolderName FunctionFolder
            => FS.folder("functions");

        public FS.FolderPath InstructionDir
            => ArchiveRoot + InstructionFolder;

        public FS.FolderPath FunctionDir
            => ArchiveRoot + FunctionFolder;

        public XedStage(FS.FolderPath root)
        {
            ArchiveRoot = root;
        }

        public IEnumerable<FS.FilePath> Files
            => ArchiveRoot.Files(ArchiveFileKinds.Txt,true);

        public int FileCount => Files.Count();

        public void Deposit(ReadOnlySpan<XedInstructionDoc> src, FS.FileName name)
        {
            var path = InstructionDir + name;
            using var writer = path.Writer();
            for(var i=0; i<src.Length; i++)
            {
                var rows = src[i];
                for(var j = 0; j < rows.RowCount; j++)
                    writer.WriteLine(rows[j].Text);
                if(i != src.Length - 1)
                    writer.WriteLine(HSep);
            }
        }

        public void Deposit(XedRuleSet[] src, FS.FileName name)
        {
            var path = FunctionDir + name;
            using var writer = path.Writer();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref src[i];
                var body = f.Terms;
                if(body.Length != 0)
                {
                    writer.WriteLine(f.Description);
                    writer.WriteLine(HSep);

                    for(var j = 0; j < body.Length; j++)
                        writer.WriteLine(body[j]);

                    if(i != src.Length - 1)
                        writer.WriteLine();
                }
            }
        }

        const string HSep = RP.PageBreak120;
    }
}