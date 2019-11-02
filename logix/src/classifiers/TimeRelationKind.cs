//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;

    /// <summary>
    /// Classifies the chronological disposition of one instant in time with respect to another
    /// </summary>
    public enum TimeRelationKind : byte
    {
        /// <summary>
        /// Indicates the subject is antecedent to the comperand
        /// </summary>
        Before = 1,
        
        /// <summary>
        /// Indicates the subject is identical to the comperand
        /// </summary>
        Matches = 2,
        
        /// <summary>
        /// Indicates the subject follows the comperand
        /// </summary>
        After = 3,

        /// <summary>
        /// Indicates the subject is inclusively between a start date and an end date
        /// </summary>
        Between = 4
    }


}