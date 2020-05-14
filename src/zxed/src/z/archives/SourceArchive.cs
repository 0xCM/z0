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

    partial class Archives
    {
        public readonly struct SourceArchive : IArchive
        {
            public static SourceArchive Create(FolderPath root)
                => new SourceArchive(root);

            public SourceArchive(FolderPath root)
            {
                this.ArchiveRoot = root;
            }

            public FolderPath ArchiveRoot {get;}
            
            public IEnumerable<FilePath> Files  
                => ArchiveRoot.Files(FileExtensions.Txt,true);

            public int FileCount => Files.Count();

            public IEnumerable<FilePath> InstructionFiles
            {
                get
                {
                    foreach(var file in Files)
                    {
                        using var reader = file.Reader();
                        while(!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if(line.Contains(InstructionMarkers.INSTRUCTION_SEQ))
                            {
                                yield return file;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}