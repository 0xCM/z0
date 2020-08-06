//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Characterizes a file-system repository for anticipated file kinds
    /// </summary>
    public interface IPartFileArchive : IPartFilePaths
    {
        /// <summary>
        /// The path to which all archive path arithmetic is relative
        /// </summary>
        FolderPath ArchiveRoot 
            => Env.Current.LogDir;
            
        /// <summary>
        /// A folder name of the form PartFolder(part):{TestPartition | AppPartition} as determined by the identifier of the entry process  
        /// </summary>
        FolderName RootPartition 
            => Part.isTest(Part.ExecutingPart) ? TestFolderName : AppFolderName;

        /// <summary>
        /// Defines a path that determines the root directory for process-specific archives 
        /// and is of the form {ArchiveRoot}/{RootPartition} 
        /// </summary>
        FolderPath ExeRoot 
            => ArchiveRoot + RootPartition;

        /// <summary>
        /// Defines a process-specific path of the form {ExeRoot}/{ExeFolder} where 
        /// ExeFolder := PartFolder(part:PartId) and {part} is the identifier of the entry process
        /// </summary>
        FolderPath PartExeDir 
            => ExeRoot + PartExeFolderName;


        [MethodImpl(Inline)]
        FolderPath PartDataDir(FolderName folder)            
            => (PartExeDir + DataFolderName) + folder;

        [MethodImpl(Inline)]
        FolderPath PartDataDir(Type t)            
            => PartDataDir(TypeFolderName(t));

        /// <summary>
        /// Defines a path of the form {ExeDir}/{folder}
        /// </summary>
        /// <param name="folder">The source folder</param>
        [MethodImpl(Inline)]
        FolderPath ExeSubDir(FolderName folder)
            => PartExeDir + folder;                

        /// <summary>
        /// Defines a path of the form {ExeRoot}/{ExeDir}/{part:Folder}
        /// </summary>
        /// <param name="part">The source part</param>
        [MethodImpl(Inline)]
        FolderPath PartDir(PartId part)
            => ExeSubDir(PartFolderName(part));
    }
}