//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Specifies archive service operations for hosted bits
    /// </summary>
    public interface IUriHexArchive : IRootedArchive
    {
        /// <summary>
        /// Enumerates the archived files
        /// </summary>
        IEnumerable<FilePath> Files();

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        IEnumerable<FilePath> Files(PartId part);

        /// <summary>
        /// Reads all files in the archive
        /// </summary>
        IEnumerable<UriHex> Read();

        /// <summary>
        /// Reads the archived files owned by a specified part
        /// </summary>
        IEnumerable<UriHex> Read(PartId part);

        /// <summary>
        /// Reads the archived files owned by a specified host
        /// </summary>
        IEnumerable<UriHex> Read(ApiHostUri host);       
         
        /// <summary>
        /// Reads all files in the archive that satisfy a supplied predicate
        /// </summary>
        IEnumerable<UriHex> Read(Func<FileName,bool> predicate);

        /// <summary>
        /// Reads the bits of an identified operation
        /// </summary>
        /// <param name="id">The source path</param>
        IEnumerable<UriHex> Read(OpIdentity id); 

        /// <summary>
        /// Reads ths bits that live at a specified path
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<UriHex> Read(FilePath src); 

    }    
}