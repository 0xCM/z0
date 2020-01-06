//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;



    /// <summary>
    /// Represents a contiguous block of memory that represents the machine code for a method
    /// </summary>
    public readonly struct MethodData : INativeMemberData
    {        
        public static MethodData Empty => default;

        [MethodImpl(Inline)]
        public MethodData(MethodInfo method, ulong StartAddress, ulong EndAddress, byte[] body)
        {
            this.Method = method;
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Body = body.ToArray();
        }

        /// <summary>
        /// The deconstructed method
        /// </summary>
        public readonly MethodInfo Method {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        public readonly ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        public readonly ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        public readonly byte[] Body {get;}
        
        public ulong Length 
            => EndAddress -StartAddress;

        public bool IsEmpty
            => Method == null || Body == null;
    }
}