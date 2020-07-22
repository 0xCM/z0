//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    
    /// <summary>
    /// Defines folder names and facilites common to all archives
    /// </summary>
    public interface TPartFolderNames
    {
        /// <summary>
        /// An archive partition for files emitted during test execution
        /// </summary>
        FolderName TestFolderName 
            => FolderName.Define("test", "Test emissions");

        /// <summary>
        /// An archive partition for files emitted during application execution
        /// </summary>
        FolderName AppFolderName 
            => FolderName.Define("apps", "Application emissions");
    
        /// <summary>
        /// An archive partition for static data
        /// </summary>
        FolderName DataFolderName 
            => FolderName.Define("data", "Reference data");

        /// <summary>
        /// An archive partition for static data
        /// </summary>
        FolderName LogFolderName 
            => FolderName.Define("logs", "Application logs");

        /// <summary>
        /// Part folder name predicated on the entry assembly
        /// </summary>
        FolderName PartExeFolderName
            => FolderName.Define(Part.ExecutingPart);

        FolderName ExtractFolderName 
            => FolderName.Define("extracted", "Raw binary extracts");
    
        FolderName ParsedFolderName 
            => FolderName.Define("parsed", "Parsed binary extracts");

        FolderName UnparsedFolderName
            => FolderName.Define("unparsed", "Extraction parse failures");

        FolderName AsmFolderName 
            => FolderName.Define("asm", "Formatted x86 assembly");

        FolderName HexFolderName  
            => FolderName.Define("code", "Hex formatted encoded x86 assembly");

        /// <summary>
        /// The imm root folder name
        /// </summary>
        FolderName ImmFolderName 
            => FolderName.Define("imm", "Immediate embedding emission root");

        /// <summary>
        /// Defines a part-specific folder name {part}
        /// </summary>
        /// <param name="part">The source part</param>
        FolderName PartFolderName(PartId part)
            => FolderName.Define(part);
            
        /// <summary>
        /// Defines a host-specific folder name {host.Name}
        /// </summary>
        /// <param name="part">The source part</param>
        FolderName HostFolderName(ApiHostUri host)
            => FolderName.Define(host);

        /// <summary>
        /// Defines a type-specific folder name {t.Name}
        /// </summary>
        /// <param name="src">The source type</param>
        FolderName TypeFolderName(Type src)
            => FolderName.Define(src.Name);

        RelativeLocation HostPartLocation(ApiHostUri host)
            => RelativeLocation.Define(PartFolderName(host.Owner), HostFolderName(host));
    }
}