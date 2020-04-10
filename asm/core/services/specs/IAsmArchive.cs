//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    /// <summary>
    /// Defines base interface for archival services that support persistence/lookup for x86 encoded asm
    /// </summary>
    public interface IAsmArchive : IService
    {
        /// <summary>
        /// The archive root to which all uri's and locations are relative
        /// </summary>
        FolderPath RootFolder {get;}

        /// <summary>
        /// The .net assembly from which deposited asm originates
        /// </summary>
        PartId SourcePart {get;}

        /// <summary>
        /// An optional api host name - that usually corresponds the the name of a type that defines the operations of interest
        /// </summary>
        string HostName {get;}        
    }

    public interface IAsmArchive<T> : IAsmArchive
        where T : IAsmArchive<T>
    {
        /// <summary>
        /// Purges all files from the archive
        /// </summary>
        T Clear();        
    }
}