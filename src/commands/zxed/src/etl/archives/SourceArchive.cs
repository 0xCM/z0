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

        public int FileCount 
            => Files.Count();

        bool ContainsMarker(FilePath file, string marker)
        {
            using var reader = file.Reader();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if(line.Contains(marker))
                    return true;
            }
            return false;
        }

        bool DefinesInstructions(FilePath file)
            => ContainsMarker(file, SourceMarkers.INSTRUCTION_SEQ);

        bool DefinesFunctions(FilePath file)
        {
            using var reader = file.Reader();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if(
                    line.Contains(SourceMarkers.FUNC_MARKER) && 
                    !line.Contains(SourceMarkers.INSTRUCTION_SEQ)
                    )
                    return true;
            }
            return false;

            //=> ContainsMarker(file, SourceMarkers.FUNC_MARKER);

        }

        public IEnumerable<FilePath> InstructionFiles
            => Files.Where(DefinesInstructions);
        
        public IEnumerable<FilePath> FunctionFiles
            => Files.Where(DefinesFunctions);

        public IEnumerable<FilePath> EnumFiles
            => Files.Where(f => f.FileName.EndsWith("enum"));
    }
 
}