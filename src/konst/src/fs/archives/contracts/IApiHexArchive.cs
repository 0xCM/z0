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
    public interface IApiHexArchive
    {
        /// <summary>
        /// The directory to which path calculations are relative
        /// </summary>
        FolderPath ArchiveRoot {get;}

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
        IEnumerable<ApiHex> Read();

        /// <summary>
        /// Reads the archived files owned by a specified part
        /// </summary>
        IEnumerable<ApiHex> Read(PartId part);

        /// <summary>
        /// Reads the archived files owned by a specified host
        /// </summary>
        IEnumerable<ApiHex> Read(ApiHostUri host);

        /// <summary>
        /// Reads all files in the archive that satisfy a supplied predicate
        /// </summary>
        IEnumerable<ApiHex> Read(Func<FileName,bool> predicate);

        /// <summary>
        /// Reads the bits of an identified operation
        /// </summary>
        /// <param name="id">The source path</param>
        IEnumerable<ApiHex> Read(OpIdentity id);

        /// <summary>
        /// Reads ths bits that live at a specified path
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<ApiHex> Read(FilePath src);

        /// <summary>
        /// Reads the code owned by a specified collection of parts
        /// </summary>
        /// <param name="owners">The owning parts</param>
        IEnumerable<IdentifiedCodeIndex> ReadIndices(params PartId[] owners);

        /// <summary>
        /// Reads the code defined by a specified file
        /// </summary>
        /// <param name="src">The source path</param>
        IdentifiedCodeIndex ReadIndex(FilePath src);
    }

    public interface IApiHexArchive<H> : IApiHexArchive
        where H : struct, IApiHexArchive<H>
    {

    }
}