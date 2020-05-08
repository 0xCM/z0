//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    using W = NumericWidth;

    partial class AsmExpr
    {
        /// <summary>
        /// Represents byte.MaxValue - 1 potential decisisions, some of which are explicitly listed
        /// </summary>
        public enum Branch8 : byte
        {
            /// <summary>
            /// If you choose not to decide you have still made a choice
            /// </summary>
            None = 0,

            Case1 = 1,

            Case2 = 2,

            Case3 = 3,

            Case4 = 4,

            Case5 = 5,

            Case6 = 6,

            Max = byte.MaxValue,
        }
    }
}