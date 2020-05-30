//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum PrimalKindSeg : byte
    {
        /// <summary>
        /// The starting index of the width field
        /// </summary>
        Width = 0,

        /// <summary>
        /// The starting index of the id field
        /// </summary>
        KindId = 3,

        /// <summary>
        /// The index of the sign flag
        /// </summary>
        Sign= 7,
    }
}