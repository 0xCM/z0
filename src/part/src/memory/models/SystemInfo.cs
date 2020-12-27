//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public struct SystemInfo
    {
        /// <summary>
        /// The page size and the granularity of page protection and commitment.
        /// </summary>
        public uint PageSize;

        /// <summary>
        /// Th lowest memory address accessible to applications and DLL's
        /// </summary>
        public MemoryAddress MinAppAddress;

        /// <summary>
        /// The highest memory address accessible to applications and DLL's
        /// </summary>
        public MemoryAddress MaxAppAddress;

        /// <summary>
        /// The granularity for the starting address at which virtual memory can be allocated
        /// </summary>
        public uint Granularity;
    }
}