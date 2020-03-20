//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// A term that is preceded by a '~' character and which is applicable to the term immediately before the '~' character
    /// </summary>
    /// <example>
    /// In the identifier 'load_g[8u](b16x8u~in,n1,n16)', the term 'in' is a modifier for the term 'b16x8u'
    /// </example>
    public enum TermModifierKind : byte
    {
        None = 0,

        /// <summary>
        /// Modifies a value argument to signify an "in" value
        /// </summary>
        In = 200,

        /// <summary>
        /// Modifies a value argument to signify an "out" value
        /// </summary>
        Out = 201,

        /// <summary>
        /// Modifies a value argument, or return type, to signify a "ref" value
        /// </summary>
        Ref = 202,

        ReadOnly = 203,
        
        First = In,

        Last = ReadOnly,
    }
}