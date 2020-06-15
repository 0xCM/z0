//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;

    using System.Collections.Generic;
    
    public readonly struct AsmArchiveConfig : IAsmArchiveConfig
    {
        public static IAsmArchiveConfig Default => default(AsmArchiveConfig);        
    }    

    public interface IAsmArchiveConfig : IPublicationArchive
    {
        FolderName IDatasetArchive.RootFolder 
            => FolderName.Define("asm");

        FolderName SourcesFolder 
            => FolderName.Define("sources");

        FolderPath Sources 
            => ArchiveRoot + SourcesFolder;

        FolderPath IcedSources
            => Sources + FolderName.Define("iced");

        FilePath OpCodeInfoPath 
            => IcedSources + FileName.Define("OpCodeInfos", FileExtensions.Txt);

        FolderPath IcedTestCaseDir
            => IcedSources + FolderName.Define("testcases");

        IEnumerable<FilePath> DecoderTests
            =>  (IcedTestCaseDir + FolderName.Define("decoder")).Files(FileExtensions.Txt).Where(f => f.FileName.StartsWith("DecoderTest"));

        IEnumerable<FilePath> MemoryTests
            =>  (IcedTestCaseDir + FolderName.Define("decoder")).Files(FileExtensions.Txt).Where(f => f.FileName.StartsWith("MemoryTest"));

        FolderName StageFolder 
            => FolderName.Define("extracts");

        FolderName ExtensionFolder 
            => FolderName.Define("extensions");

        FolderName CategoryFolder 
            => FolderName.Define("categories");
        
        FolderPath XedSources 
            => Sources + FolderName.Define("xed");

        IEnumerable<FilePath> IcedInstructionTests
            =>  (IcedTestCaseDir + FolderName.Define("instructions")).Files(FileExtensions.Txt);

        IEnumerable<FilePath> IcedEncoderTests
            =>  (IcedTestCaseDir + FolderName.Define("encoder")).Files(FileExtensions.Txt);        
    }
}