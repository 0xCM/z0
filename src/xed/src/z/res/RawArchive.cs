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
        public readonly struct RawArchive
        {
            public static RawArchive Create(FolderPath root)
                => new RawArchive(root);

            public RawArchive(FolderPath root)
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
                            if(line.Contains(InstructionFileMarkers.InstructionSeq))
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