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
        string ApiHost {get;}        
    }

    public interface IAsmArchive<T> : IAsmArchive
        where T : IAsmArchive<T>
    {
        /// <summary>
        /// Purges all files from the archive
        /// </summary>
        T Clear();        
    }

    public interface IAsmCodeArchive : IAsmArchive<IAsmCodeArchive>
    {
        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        Option<TypedAsm<T>> Read<T>(OpIdentity m, T t = default)
            where T : unmanaged;

        /// <summary>
        /// Reads all files in the archive
        /// </summary>
        IEnumerable<AsmCode> Read();

        /// <summary>
        /// Reads all files in the archive that satisfy a supplied predicate
        /// </summary>
        IEnumerable<AsmCode> Read(Func<FileName,bool> predicate);

        /// <summary>
        /// Reads the content of a hexline default-formatted file
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<AsmCode> Read(OpIdentity src); 

        /// <summary>
        /// Reads the content of a hexline default-formatted file
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<AsmCode> Read(FilePath src); 

        /// <summary>
        /// Reads the content of hexline default-formatted file with a specified name
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<AsmCode> Read(string name); 

        /// <summary>
        /// Reads the content of a hexline-formatted file with specified identity and byte separators
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<AsmCode> Read(FilePath src, char idsep, char bytesep);
    }    
}