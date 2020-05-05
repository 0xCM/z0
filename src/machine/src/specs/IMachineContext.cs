//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;

    public interface IMachineContext : IContext
    {
        IAppMsgSink AppMsgSink {get;}        
        
        PartId[] CodeParts {get;}

        ICaptureArchive Archive {get;}

        FilePath[] ExtractFiles
            => Archive.Files(Archive.ExtractDir, CodeParts);

        FilePath[] ParseFiles 
            => Archive.Files(Archive.ParsedDir, CodeParts);

        FilePath[] AsmFiles 
            => Archive.Files(Archive.AsmDir, CodeParts);

        FilePath[] CodeFiles 
            => Archive.Files(Archive.CodeDir, CodeParts);

        FilePath[] UnparsedFiles
            => Archive.Files(Archive.UnparsedDir, CodeParts);
    }
}