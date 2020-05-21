//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Linq;

    using System.Collections.Generic;
    
    using static Memories;

    using F = LiteralTableField;
    using T = LiteralRecord;

    public readonly struct AsmArchiveConfig : IAsmArchiveConfig
    {
        public static IAsmArchiveConfig Default => default(AsmArchiveConfig);        
    }    

    public interface IAsmArchiveConfig
    {
        FolderName RootFolder 
            => FolderName.Define("asm");

        FolderPath ArchiveRoot
            => Env.Current.LogDir + RootFolder;

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

        FilePath DatasetPath(IAsmDataModel model)
            => DatasetDir + FileName.Define(model.Name, DataFileExt);

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