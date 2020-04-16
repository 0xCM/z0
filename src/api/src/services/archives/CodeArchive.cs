//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ICodeArchive : IService
    {
        FolderName RootFolder 
            => FolderName.Define("emissions");

        FolderName ExtractFolder 
            => FolderName.Define("extracted");
        
        FolderName HexFolder 
            => FolderName.Define("code");

        FolderName ParsedFolder 
            => FolderName.Define("parsed");

        FolderName AsmFolder 
            => FolderName.Define("asm");

        FolderName LogFolder
            => FolderName.Define("logs");

        FolderName ReportFolder 
            => FolderName.Define($"reports");  

        FolderName ImmRootFolder 
            => FolderName.Define("imm");

        FileExtension ExtractExt => FileExtension.Define($"x.{FileExtensions.Csv}");

        FileExtension ParsedExt => FileExtension.Define($"p.{FileExtensions.Csv}");

        FileExtension HexExt => FileExtensions.Hex;

        FileExtension AsmExt => FileExtensions.Asm;

        FileExtension CilExt => FileExtensions.Il;
    }
}