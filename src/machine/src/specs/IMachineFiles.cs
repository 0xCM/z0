//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IMachineFiles : IContextual<IMachineContext>
    {
        ICaptureArchive Archive {get;}

        FilePath[] ExtractFiles
            => Archive.Files(Archive.ExtractDir, Context.Parts);

        FilePath[] ParseFiles 
            => Archive.Files(Archive.ParsedDir, Context.Parts);

        FilePath[] ParseFileFilter(PartId part)
            => Archive.Files(Archive.ParsedDir, Context.Parts.Where(p => p == part));

        FilePath[] AsmFiles 
            => Archive.Files(Archive.AsmDir, Context.Parts);

        FilePath[] CodeFiles 
            => Archive.Files(Archive.CodeDir, Context.Parts);

        FilePath[] UnparsedFiles
            => Archive.Files(Archive.UnparsedDir, Context.Parts);
    }
}