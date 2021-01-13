//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    readonly struct XedStage : IPartFilePaths
    {
        public FS.FolderPath Root {get;}

        public FS.FolderName InstructionFolder
            => FS.folder("instructions");

        public FS.FolderName FunctionFolder
            => FS.folder("functions");

        public FS.FolderPath InstructionDir
            => Root + InstructionFolder;

        public FS.FolderPath FunctionDir
            => Root + FunctionFolder;

        public XedStage(FS.FolderPath root)
            => Root = root;

        public IEnumerable<FS.FilePath> Files
            => Root.Files(FileExtensions.Txt,true);

        public int FileCount => Files.Count();

        public void Deposit(ReadOnlySpan<XedInstructionDoc> src, FS.FileName name)
        {
            var path = InstructionDir + name;
            using var writer = path.Writer();
            for(var i=0; i<src.Length; i++)
            {
                var rows = src[i];
                for(var j = 0; j <rows.RowCount; j++)
                    writer.WriteLine(rows[j].RowText);
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