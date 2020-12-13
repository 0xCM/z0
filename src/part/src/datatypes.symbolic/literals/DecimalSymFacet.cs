//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DecimalSym;

    /// <summary>
    /// Defines <see cref='DecimalSym' /> classifiers
    /// </summary>
    [FacetProvider(typeof(DecimalSym))]
    public enum DecimalSymFacet : ushort
    {
        /// <summary>
        /// The first declared symbol
        /// </summary>
        First = d0,

        /// <summary>
        /// The last declared symbol
        /// </summary>
        Last = d9,
    }
}