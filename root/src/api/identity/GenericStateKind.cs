//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    public enum GenericStateKind : byte
    {
        /// <summary>
        /// Indicates subject is nongeneric
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates subject is a generic defintion
        /// </summary>
        Definition = 16,

        /// <summary>
        /// Indicates subject is open generic
        /// </summary>
        Open = 32,

        /// <summary>
        /// Indicates subject is closed generic
        /// </summary>
        Closed = 64,
    }
}