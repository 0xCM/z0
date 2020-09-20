//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum ApiProviderKind : ulong
    {
        None,

        /// <summary>
        /// Indicates a classical or domain-specific value type that organizes data by some principle
        /// </summary>
        DataStructure,

        DataType,

        Stateless,

        DataSummary,
    }
}