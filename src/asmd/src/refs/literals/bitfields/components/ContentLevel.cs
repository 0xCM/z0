//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    /// <summary>
    /// Defines level hierarchy component values
    /// </summary>
    [FieldComponent(typeof(ContentField))]
    public enum ContentLevel : byte
    {        
        /// <summary>
        /// type: [a].b.c
        /// </summary>
        L0 = 0,

        /// <summary>
        /// type: a.[b].c
        /// </summary>
        L1 = 4,

        /// <summary>
        /// type: a.b.[c]
        /// </summary>
        L2 = 8,
        
        /// <summary>
        /// [type]: a.b.c
        /// </summary>
        Type = 12
    }
}