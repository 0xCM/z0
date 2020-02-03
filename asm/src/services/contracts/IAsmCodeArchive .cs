//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.AsmSpecs;

    using static zfunc;

    /// <summary>
    /// Defines base interface for asm archive services
    /// </summary>
    public interface IAsmArchive : IAsmService
    {
        FolderPath Root {get;}
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
        Option<AsmCode<T>> Read<T>(OpIdentity m, T t = default)
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