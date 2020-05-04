//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines service contract to support reading text-formatted encoded x86 asm data
    /// </summary>
    public interface IHostBitsReader : IService
    {
        /// <summary>
        /// Reads the content of a source file
        /// </summary>
        /// <param name="src">The source file path</param>
        IEnumerable<HostedBits> Read(FilePath src);
    }

    public readonly struct HostBitsReader : IHostBitsReader
    {
        public static IHostBitsReader Service => default(HostBitsReader);

        public IEnumerable<HostedBits> Read(FilePath src)
            => throw new NotImplementedException();
    }
}
