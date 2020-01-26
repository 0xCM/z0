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
    public interface IAsmArchive
    {
        /// <summary>
        /// The top-level organization segment
        /// </summary>
        string Catalog {get;}

        /// <summary>
        /// The sub-level organization segment
        /// </summary>
        string Subject {get;}
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
        /// Materializes an untyped code block from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        Option<AsmCode> ReadBlock(Moniker m);

        /// <summary>
        /// Materializes a typed code block (per user's insistence as the type is not checkeed in any way) 
        /// from hex data contained in the assembly log archive
        /// </summary>
        /// <param name="subfolder">The asm log subfolder</param>
        /// <param name="m">The identifying moniker</param>
        Option<AsmCode<T>> ReadBlock<T>(Moniker m, T t = default)
            where T : unmanaged;

        /// <summary>
        /// Returns the assembly hex file paths with filenames that satisfy a substring match predicate
        /// </summary>
        /// <param name="match">The match predicate</param>
        IEnumerable<FilePath> Files(string match);  

        /// <summary>
        /// Reads the content of a hexline default-formatted file
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<AsmCode> Read(Moniker src); 

        /// <summary>
        /// Reads the content of a hexline default-formatted file
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<AsmCode> Read(FilePath src); 

        /// <summary>
        /// Reads the content of a hexline-formatted file with specified identity and byte separators
        /// </summary>
        /// <param name="src">The source path</param>
        IEnumerable<AsmCode> Read(FilePath src, char idsep, char bytesep);
    }    

    /// <summary>
    /// Defines asm archival service operations
    /// </summary>
    public interface IAsmFunctionArchive : IAsmArchive<IAsmFunctionArchive>
    {
        /// <summary>
        /// Saves a function to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        AsmEmissionToken Save(AsmFunction src);

        /// <summary>
        /// Saves a stream of functions to the archive
        /// </summary>
        /// <param name="src">The source function</param>
        IEnumerable<AsmEmissionToken> Save(IEnumerable<AsmFunction> src);

        /// <summary>
        /// Saves a group of related functtions to the archive
        /// </summary>
        /// <param name="group">The source group</param>
        IEnumerable<AsmEmissionToken> Save(AsmFunctionGroup group);

    }    
}