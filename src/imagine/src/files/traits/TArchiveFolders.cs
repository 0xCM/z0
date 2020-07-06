//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    /// <summary>
    /// Defines folder names and facilites common to all archives
    /// </summary>
    public interface TArchiveFolders
    {
        /// <summary>
        /// An archive partition for files emitted during test execution
        /// </summary>
        FolderName TestPartition 
            => FolderName.Define("test", "Test emissions");

        /// <summary>
        /// An archive partition for files emitted during application execution
        /// </summary>
        FolderName AppPartition 
            => FolderName.Define("apps", "Application emissions");
    
        /// <summary>
        /// An archive partition for static data
        /// </summary>
        FolderName DataPartition 
            => FolderName.Define("data", "Reference data");

        /// <summary>
        /// A folder name of form PartFolder(part:PartId) where {part} is the entry process identifier
        /// </summary>
        FolderName ExeFolder 
            => FolderName.Define(Part.ExecutingPart);

        FolderName CodeFolder  
            => FolderName.Define("code", "Hex formatted encoded x86 assembly");

        FolderName AsmFolder 
            => FolderName.Define("asm", "Formatted x86 assembly");
    }
}