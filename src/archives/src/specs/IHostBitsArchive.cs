//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    public interface IHostBitsArchive : IService
    {
        /// <summary>
        /// The archive root to which all uri's and locations are relative
        /// </summary>
        FolderPath ArchiveRoot {get;}

        /// <summary>
        /// The .net assembly from which deposited asm originates
        /// </summary>
        PartId Part {get;}

        /// <summary>
        /// The api host
        /// </summary>
        ApiHostUri Host {get;}        

        /// <summary>
        /// Enumerates the archived files
        /// </summary>
        IEnumerable<FilePath> Files();

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        IEnumerable<FilePath> Files(PartId owner);

        /// <summary>
        /// Reads all files in the archive
        /// </summary>
        IEnumerable<OperationBits> Read();

        /// <summary>
        /// Reads the archived files owned by a specified part
        /// </summary>
        IEnumerable<OperationBits> Read(PartId owner);

        /// <summary>
        /// Reads all files in the archive that satisfy a supplied predicate
        /// </summary>
        IEnumerable<OperationBits> Read(Func<FileName,bool> predicate);

        /// <summary>
        /// Reads the content of a hexline default-formatted file
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<OperationBits> Read(OpIdentity src); 

        /// <summary>
        /// Reads the content of a hexline default-formatted file
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<OperationBits> Read(FilePath src); 

        /// <summary>
        /// Reads the content of hexline default-formatted file with a specified name
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<OperationBits> Read(string name); 
    }    
}