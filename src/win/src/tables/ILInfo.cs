//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;

    /// <summary>
    /// Returns information about the IL for a method.
    /// </summary>
    public struct ILInfo
    {
        /// <summary>
        /// Gets the address in memory of where the IL for a particular method is located.
        /// </summary>
        public ulong Address;

        /// <summary>
        /// Gets the length (in bytes) of the IL method body.
        /// </summary>
        public int Length;

        /// <summary>
        /// Gets the flags associated with the IL code.
        /// </summary>
        public uint Flags;

        /// <summary>
        /// Gets the local variable signature token for this IL method.
        /// </summary>
        public uint LocalVarSignatureToken;

        public ILInfo(ulong address, int len, uint flags, uint localVarSignatureToken)
        {
            Address = address;
            Length = len;
            Flags = flags;
            LocalVarSignatureToken = localVarSignatureToken;
        }
    }
}