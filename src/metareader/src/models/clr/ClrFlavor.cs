//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ClrDataModel
    {
        /// <summary>
        /// Returns the "flavor" of CLR this module represents.
        /// </summary>
        public enum ClrFlavor
        {
            /// <summary>
            /// This is the full version of CLR included with windows.
            /// </summary>
            Desktop = 0,

            /// <summary>
            /// For .NET Core
            /// </summary>
            Core = 3
        }
    }
}