//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    /// <summary>
    /// Defines vendor reference component values
    /// </summary>
    [FieldComponent(typeof(DocField))]
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