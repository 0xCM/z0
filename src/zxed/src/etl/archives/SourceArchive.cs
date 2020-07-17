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

    public readonly struct XedSourceArchive : TPartFileArchive
    {
        public static XedSourceArchive Create(FolderPath root)
            => new XedSourceArchive(root);

        public XedSourceArchive(FolderPath root)
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
            => ContainsMarker(file, XedSourceMarkers.INSTRUCTION_SEQ);

        bool DefinesFunctions(FilePath file)
        {
            using var reader = file.Reader();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if(
                    line.Contains(XedSourceMarkers.FUNC_MARKER) && 
                    !line.Contains(XedSourceMarkers.INSTRUCTION_SEQ)
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