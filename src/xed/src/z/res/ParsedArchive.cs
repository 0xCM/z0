//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class Res
    {
        public readonly struct ParsedArchive
        {
            public FolderName InstructionFolder => FolderName.Define("instructions");

            public FolderPath InstructionDir => ArchiveRoot + InstructionFolder;
            
            public static ParsedArchive Create(FolderPath root)
                => new ParsedArchive(root);

            public ParsedArchive(FolderPath root)
            {
                ArchiveRoot = root;
            }

            public FolderPath ArchiveRoot {get;}
            
            public IEnumerable<FilePath> Files  
                => ArchiveRoot.Files(FileExtensions.Txt,true);

            public int FileCount => Files.Count();

            public void Deposit(Instruction[] src, FileName name)
            {
                var path = InstructionDir + name;
                using var writer = path.Writer();
                for(var i=0; i<src.Length; i++)
                {
                    var rows = src[i];
                    for(var j = 0; j < rows.RowCount; j++)                
                        writer.WriteLine(rows[j].Text);
                    if(i != src.Length - 1)
                        writer.WriteLine(Footer);
                }
            }

            const string Footer = "--------------------------------------------------------------------------------------------------------";

        }
    }
}