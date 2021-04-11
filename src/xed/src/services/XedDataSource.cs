//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct XedDataSource : IPartFilePaths
    {
        public FS.FolderPath Root {get;}

        public FS.Files Files {get;}

        [MethodImpl(Inline)]
        internal XedDataSource(FS.FolderPath root)
        {
            Root = root;
            Files = Root.Files(FS.Txt, true);
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

        public FS.Files InstructionFiles
            => Files.Where(DefinesInstructions);

        static FS.FileExt Cfg => FS.ext("cfg");

        public FS.Files ConfigFiles
            => Files.Where(Cfg);

        public FS.Files FunctionFiles
            => Files.Where(DefinesFunctions);

        public FS.Files EnumFiles
            => Files.Where(f => f.FileName.EndsWith("enum"));
    }
}