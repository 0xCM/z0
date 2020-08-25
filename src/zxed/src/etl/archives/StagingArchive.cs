//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public readonly struct XedStagingArchive : IPartFilePaths
    {
        public static XedStagingArchive Create(FolderPath root)
            => new XedStagingArchive(root);

        public FolderPath ArchiveRoot {get;}

        public FolderName InstructionFolder
            => FolderName.Define("instructions");

        public FolderName FunctionFolder
            => FolderName.Define("functions");

        public FolderPath InstructionDir
            => ArchiveRoot + InstructionFolder;

        public FolderPath FunctionDir
            => ArchiveRoot + FunctionFolder;

        public XedStagingArchive(FolderPath root)
        {
            ArchiveRoot = root;
        }

        public IEnumerable<FilePath> Files
            => ArchiveRoot.Files(FileExtensions.Txt,true);

        public int FileCount => Files.Count();

        public void Deposit(ReadOnlySpan<XedInstructionData> src, FileName name)
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

        public void Deposit(XedFunctionData[] src, FileName name)
        {
            var path = FunctionDir + name;
            using var writer = path.Writer();
            for(var i=0; i<src.Length; i++)
            {

                ref readonly var f = ref src[i];
                var body = f.Body;
                if(body.Length != 0)
                {

                    writer.WriteLine(f.Declaration);
                    writer.WriteLine(HSep);

                    for(var j = 0; j < body.Length; j++)
                        writer.WriteLine(body[j]);

                    if(i != src.Length - 1)
                        writer.WriteLine();
                }

            }
        }

        const string HSep = "--------------------------------------------------------------------------------------------------------";
    }

}