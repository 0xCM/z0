//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using P = Pow2x32;

    /// <summary>
    /// Classifies method *value* parameters
    /// </summary>
    [Flags]
    public enum ArgClass : uint
    {
        /// <summary>
        /// No classification conferred
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies paramters that are declared with the "in" modifier
        /// </summary>
        In = P.P2ᐞ00,

        /// <summary>
        /// Classifies paramters that are declared with the "out" modifier
        /// </summary>
        Out = P.P2ᐞ01,

        /// <summary>
        /// Classifies paramters that are declared with the "ref" modifier
        /// </summary>
        Ref = P.P2ᐞ02,

        /// <summary>
        /// Classifies paramters that require literal values
        /// </summary>
        Literal = P.P2ᐞ03,

        /// <summary>
        /// Classifies paramters that require primitive values
        /// </summary>
        PrimalValue = P.P2ᐞ04,

        /// <summary>
        /// Classifies paramters that require primitive numeric values
        /// </summary>
        NumericValue = P.P2ᐞ05,

        /// <summary>
        /// Classifies paramters that are of <see cref='string'/> type
        /// </summary>
        Text = P.P2ᐞ06,

    }
}