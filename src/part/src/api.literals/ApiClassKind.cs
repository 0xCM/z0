//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum ApiClassKind : ulong
    {
        None,

        /// <summary>
        /// Indicates a classical or domain-specific value type that organizes data by some principle
        /// </summary>
        DataStructure,

        /// <summary>
        /// Indicates an exposed type that provides instance methods
        /// </summary>
        Service,

        /// <summary>
        /// Indicates an exposed type to which a <see cref='LiteralProviderAttribute'/> is attached
        /// </summary>
        LiteralSet,

        ApiDataType,

        ApiHost,

        ApiService,

        ApiOp,

        /// <summary>
        /// Indicates a capability set driven by configuration files and/or serializable parameters
        /// </summary>
        Tool,


        DataSummary,

        DataIndex,
    }
}