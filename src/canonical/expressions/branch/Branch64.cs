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
        public enum BranchSize : byte
        {
            /// <summary>
            /// Unspecified kind of branch
            /// </summary>
            None = 0,

            /// <summary>
            /// An 8-bit branch
            /// </summary>
            Branch8 = W.W8,

            /// <summary>
            /// A 16-bit branch
            /// </summary>
            Brach16 = W.W16,

            /// <summary>
            /// A 32-bit branch
            /// </summary>
            Branch32 = W.W32,

            /// <summary>
            /// A 64-bit branch
            /// </summary>
            Branch64 = W.W64
        }


        /// <summary>
        /// Represents ulong.MaxValue - 1 potential decisisions, some of which are explicitly listed
        /// </summary>
        public enum Branch64 : ulong
        {
            /// <summary>
            /// If you choose not to decide you have still made a choice
            /// </summary>
            None = 0,
            
            Case0 = 0,

            Case1 = 1,

            Case2 = 2,

            Case3 = 3,

            Case4 = 4,

            Case5 = 5,

            Case6 = 6,

            Max = ulong.MaxValue,
        }
    }
}