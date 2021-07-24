//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct XedDataSource : IFileArchive
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
            using var reader = file.Utf8Reader();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if(line.Contains(XedSourceMarkers.RuleMarker) && !line.Contains(XedSourceMarkers.Instructions))
                    return true;
            }
            return false;
        }


    }
}