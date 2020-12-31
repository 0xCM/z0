//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct XedSources : IPartFilePaths
    {
        public FS.FolderPath Root {get;}

        public FS.FilePath[] Files {get;}

        [MethodImpl(Inline)]
        internal XedSources(FS.FolderPath root)
        {
            Root = root;
            Files = Root.Files(FileExtensions.Txt, true);
        }

        bool DefinesInstructions(FS.FilePath file)
            => file.Contains(XedSourceMarkers.Instructions, out var _);

        bool DefinesFunctions(FS.FilePath file)
        {
            using var reader = file.Reader();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if(line.Contains(XedSourceMarkers.RuleMarker) && !line.Contains(XedSourceMarkers.Instructions))
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