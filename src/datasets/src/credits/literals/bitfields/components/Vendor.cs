//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    partial class CreditTypes
    {
        /// <summary>
        /// Defines vendor reference component values
        /// </summary>
        public enum Vendor : byte
        {
            None = 0,

            /// <summary>
            /// Intel documentation
            /// </summary>
            Intel = 1,

            /// <summary>
            /// AMD documentation
            /// </summary>
            Amd = 2
        }

    }

}