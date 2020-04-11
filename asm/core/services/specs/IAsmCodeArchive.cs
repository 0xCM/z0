//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;

    public interface IAsmCodeArchive : IAsmArchive<IAsmCodeArchive>
    {

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

    }    
}