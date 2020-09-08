//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ImageTables
    {
        /// <summary>
        /// Specifies how arguments in a given signature are passed from the caller to the callee.
        /// Underlying values correspond to the representation in the leading signature byte
        /// represented by <see cref="SigHeader"/>.
        /// </summary>
        public enum SignatureCallingConvention : byte
        {
            /// <summary>
            /// Managed calling convention with fixed-length argument list.
            /// </summary>
            Default = 0x0,

            /// <summary>
            /// Unmanaged C/C++-style calling convention where the call stack is cleaned by the caller.
            /// </summary>
            CDecl = 0x1,

            /// <summary>
            /// Unmanaged calling convention where call stack is cleaned up by the callee.
            /// </summary>
            StdCall = 0x2,

            /// <summary>
            /// Unmanaged C++-style calling convention for calling instance member functions with a fixed argument list.
            /// </summary>
            ThisCall = 0x3,

            /// <summary>
            /// Unmanaged calling convention where arguments are passed in registers when possible.
            /// </summary>
            FastCall = 0x4,

            /// <summary>
            /// Managed calling convention for passing extra arguments.
            /// </summary>
            VarArgs = 0x5,
        }
    }
}