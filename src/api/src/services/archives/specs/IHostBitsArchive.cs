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
        FolderPath RootFolder {get;}

        /// <summary>
        /// The .net assembly from which deposited asm originates
        /// </summary>
        PartId DefiningPart {get;}

        /// <summary>
        /// The api host
        /// </summary>
        ApiHostUri ApiHost {get;}        

        /// <summary>
        /// Reads all files in the archive
        /// </summary>
        IEnumerable<ApiBits> Read();

        /// <summary>
        /// Reads all files in the archive that satisfy a supplied predicate
        /// </summary>
        IEnumerable<ApiBits> Read(Func<FileName,bool> predicate);

        /// <summary>
        /// Reads the content of a hexline default-formatted file
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<ApiBits> Read(OpIdentity src); 

        /// <summary>
        /// Reads the content of a hexline default-formatted file
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<ApiBits> Read(FilePath src); 

        /// <summary>
        /// Reads the content of hexline default-formatted file with a specified name
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<ApiBits> Read(string name); 
    }    
}