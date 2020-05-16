//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using System.Collections.Generic;

    public readonly struct AsmArchiveConfig : IAsmArchiveConfig
    {
        public static IAsmArchiveConfig Default => default(AsmArchiveConfig);        
    }    

    public interface IAsmArchiveConfig
    {
        FolderName RootFolder 
            => FolderName.Define("data");

        FolderPath ArchiveRoot
            => FolderPath.Define(@"J:\dev\projects\z0\src\commands") + RootFolder;

        FolderName SourcesFolder 
            => FolderName.Define("sources");


        FolderPath Sources 
            => ArchiveRoot + SourcesFolder;

        FolderPath IcedSources
            => Sources + FolderName.Define("iced");


        FolderPath IcedTestCaseDir
            => IcedSources + FolderName.Define("testcases");

        IEnumerable<FilePath> IcedDecoderTests
            =>  (IcedTestCaseDir + FolderName.Define("decoder")).Files(FileExtensions.Txt);

        FolderName StageFolder 
            => FolderName.Define("extracts");

        FolderName DatasetFolder 
            => FolderName.Define("datasets");

        FolderName ExtensionFolder 
            => FolderName.Define("extensions");

        FolderName CategoryFolder 
            => FolderName.Define("categories");

        FileExtension DataFileExt 
            => FileExtensions.Csv;

        FilePath DatasetPath(string dsname)
            => DatasetDir + FileName.Define(dsname, DataFileExt);

        FolderPath DatasetDir 
            => ArchiveRoot + DatasetFolder;
        

        FolderPath XedSources 
            => Sources + FolderName.Define("xed");


        IEnumerable<FilePath> IcedInstructionTests
            =>  (IcedTestCaseDir + FolderName.Define("instructions")).Files(FileExtensions.Txt);

        IEnumerable<FilePath> IcedEncoderTests
            =>  (IcedTestCaseDir + FolderName.Define("encoder")).Files(FileExtensions.Txt);        
    }
}