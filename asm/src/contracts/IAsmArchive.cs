//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Defines base interface for archival services that support persistence/lookup for x86 encoded asm
    /// </summary>
    public interface IAsmArchive : IAsmService
    {
        /// <summary>
        /// The archive root to which all uri's and locations are relative
        /// </summary>
        FolderPath RootFolder {get;}

        /// <summary>
        /// The .net assembly from which deposited asm originates
        /// </summary>
        AssemblyId Origin {get;}

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