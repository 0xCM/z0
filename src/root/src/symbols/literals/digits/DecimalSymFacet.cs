//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DecimalDigitSym;

    /// <summary>
    /// Defines <see cref='DecimalDigitSym' /> classifiers
    /// </summary>
    [FacetProvider(typeof(DecimalDigitSym))]
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