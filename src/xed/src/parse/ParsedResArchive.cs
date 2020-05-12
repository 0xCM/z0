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

    public readonly struct ParsedResArchive
    {
        public FolderName InstructionFolder => FolderName.Define("instructions");

        public FolderPath InstructionDir => ArchiveRoot + InstructionFolder;
        
        public static ParsedResArchive Create(FolderPath root)
            => new ParsedResArchive(root);

        public ParsedResArchive(FolderPath root)
        {
            ArchiveRoot = root;
        }

        public FolderPath ArchiveRoot {get;}
        
        public IEnumerable<FilePath> Files  
            => ArchiveRoot.Files(FileExtensions.Txt,true);

        public int FileCount => Files.Count();

        public void Deposit(ResInstruction[] src, FileName name)
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