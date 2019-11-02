//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Classifies bitwise shift operators
    /// </summary>
    public enum ShiftOpKind : byte
    {
        /// <summary>
        /// Classifies a logical left-shift
        /// </summary>
        Sll = 1,

        /// <summary>
        /// Classifies a logical right-shift
        /// </summary>
        Srl = 2,

        /// <summary>
        /// Classifies a left circular shift
        /// </summary>
        Rotl = 4,

        /// <summary>
        /// Classifies a right circular shift
        /// </summary>
        Rotr  = 8,
    }
}