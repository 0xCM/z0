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

    public readonly struct XedSourceArchive : IPartFilePaths
    {
        public static XedSourceArchive Create(FS.FolderPath root)
            => new XedSourceArchive(root);

        public FolderPath ArchiveRoot {get;}

        public FilePath[] Files {get;}

        public XedSourceArchive(FS.FolderPath root)
        {
            ArchiveRoot = FolderPath.Define(root.Name);
            Files = ArchiveRoot.Files(FileExtensions.Txt,true).Array();
        }

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
        }

        public FilePath[] InstructionFiles
            => Files.Where(DefinesInstructions);

        public FilePath[] FunctionFiles
            => Files.Where(DefinesFunctions);

        public FilePath[] EnumFiles
            => Files.Where(f => f.FileName.EndsWith("enum"));
    }

}