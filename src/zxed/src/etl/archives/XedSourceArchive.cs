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

        public FS.FolderPath ArchiveRoot {get;}

        public FS.FilePath[] Files {get;}

        public XedSourceArchive(FS.FolderPath root)
        {
            ArchiveRoot = root;
            Files = ArchiveRoot.Files(GlobalExtensions.Txt,true).Array();
        }

        bool ContainsMarker(FS.FilePath file, string marker)
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

        bool DefinesInstructions(FS.FilePath file)
            => ContainsMarker(file, XedSourceMarkers.InstructionSeq);

        bool DefinesFunctions(FS.FilePath file)
        {
            using var reader = file.Reader();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if(
                    line.Contains(XedSourceMarkers.RuleMarker) &&
                    !line.Contains(XedSourceMarkers.InstructionSeq)
                    )
                    return true;
            }
            return false;
        }

        public FS.FilePath[] InstructionFiles
            => Files.Where(DefinesInstructions);

        public FS.FilePath[] FunctionFiles
            => Files.Where(DefinesFunctions);

        public FS.FilePath[] EnumFiles
            => Files.Where(f => f.FileName.EndsWith("enum"));
    }
}