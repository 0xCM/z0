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

    public interface IOperationalArchive : IRootedArchive
    {
        /// <summary>
        /// Enumerates the archived files that are owned by a specified part
        /// </summary>
        /// <param name="owner">The owning paret</param>
        IEnumerable<FilePath> List(PartId owner);

        /// <summary>        
        /// Reads a hex data file
        /// </summary>
        /// <param name="src">The source file path</param>
        IEnumerable<HostedBits> ReadHex(FilePath src);

        /// <summary>        
        /// Reads a hex data file
        /// </summary>
        /// <param name="src">The defining host</param>
        IEnumerable<HostedBits> ReadHex(ApiHostUri host);
    }   
}