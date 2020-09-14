//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    partial struct ClrStorage
    {
        /// <summary>
        /// Calling convention for the PInvoke
        /// </summary>
        public enum PInvokeCallingConvention
        {
            /// <summary>
            /// Windows API call.
            /// Also platformapi in ilasm.
            /// </summary>
            WinApi,
            /// <summary>
            /// Standard C style call.
            /// </summary>
            CDecl,
            /// <summary>
            /// Standard C++ style call
            /// </summary>
            StdCall,
            /// <summary>
            /// method accepts implicit this pointer.
            /// </summary>
            ThisCall,
            /// <summary>
            /// C style fast call.
            /// </summary>
            FastCall,
        }
    }
}