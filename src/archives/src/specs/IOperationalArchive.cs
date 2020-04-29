//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IOperationalArchive
    {
        /// <summary>
        /// The archive root to which all uri's and locations are relative
        /// </summary>
        FolderPath ArchiveRoot {get;}

        /// <summary>
        /// Enumerates the archived files that are owned by a specified part
        /// </summary>
        /// <param name="owner">The owning paret</param>
        IEnumerable<FilePath> List(PartId owner);

        /// <summary>        
        /// Reads a hex data file
        /// </summary>
        /// <param name="src">The source file path</param>
        IEnumerable<OperationBits> ReadHex(FilePath src);

        /// <summary>        
        /// Reads a hex data file
        /// </summary>
        /// <param name="src">The defining host</param>
        IEnumerable<OperationBits> ReadHex(ApiHostUri host);
    }   

}