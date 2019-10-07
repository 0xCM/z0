//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    using static zfunc;


    /// <summary>
    /// Represents an address space: a contiguous range of integers that identify
    /// relative memory locations
    /// </summary>
    public readonly struct AddressSpace
    {        
        public AddressSpace(ulong min, ulong max)
        {
            this.Min = min;
            this.Max = max;
        }

        /// <summary>
        /// Specfifies the addres of the first available byte
        /// </summary>
        public readonly ulong Min;

        /// <summary>
        /// Specfifies the addres of the last available byte
        /// </summary>
        public readonly ulong Max;
    }


}