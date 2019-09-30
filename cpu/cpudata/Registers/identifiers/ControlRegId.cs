//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    

    [Flags]
    public enum ControlRegId : ulong
    {
        
        /// <summary>
        /// Identifies the 32-bit control register C0
        /// </summary>
        c0 = 0,
        
        /// <summary>
        /// Identifies the 32-bit control register C1
        /// </summary>
        c1 = c0 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C2
        /// </summary>
        c2 = c1 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C3
        /// </summary>
        c3 = c2 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C4
        /// </summary>
        c4 = c3 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C5
        /// </summary>
        c5 = c4 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C6
        /// </summary>
        c6 = c5 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C7
        /// </summary>
        c7 = c6 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C8
        /// </summary>
        c8 = c7 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C9
        /// </summary>
        c9 = c8 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C10
        /// </summary>
        c10 = c9 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C11
        /// </summary>
        c11 = c10 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C12
        /// </summary>
        c12 = c11 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C13
        /// </summary>
        c13 = c12 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C14
        /// </summary>
        c14 = c13 + 1,

        /// <summary>
        /// Identifies the 32-bit control register C15
        /// </summary>
        c15 = c14 + 1,

    }
}