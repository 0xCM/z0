//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    /// <summary>
    /// Characterizes a file-system repository for anticipated file kinds
    /// </summary>
    public interface IArchive : 
        IService,
        IPathServices,
        IArchiveExtensions, 
        IArchiveFolders, 
        IArchiveFileNames         
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
            => ExecutingApp.IsTest() ? TestPartition : AppPartition;

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
        FolderPath ExeDir 
            => ExeRoot + ExeFolder;

        /// <summary>
        /// Defines a path of the form {ExeDir}/{folder}
        /// </summary>
        /// <param name="folder">The source folder</param>
        [MethodImpl(Inline)]
        FolderPath ExeSubDir(FolderName folder)
            => ExeDir + folder;                

        [MethodImpl(Inline)]
        FolderPath ExeDataDir(FolderName folder)            
            => (ExeDir + DataPartition) + folder;

        [MethodImpl(Inline)]
        FolderPath ExeDataDir(Type t)            
            => ExeDataDir(TypeFolder(t));

        /// <summary>
        /// Defines a path of the form {ExeRoot}/{ExeDir}/{part:Folder}
        /// </summary>
        /// <param name="part">The source part</param>
        [MethodImpl(Inline)]
        FolderPath PartDir(PartId part)
            => ExeSubDir(PartFolder(part));
    }
}