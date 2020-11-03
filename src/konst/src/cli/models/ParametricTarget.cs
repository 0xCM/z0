//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using T = ClrTypeKind;

    /// <summary>
    /// Classifies targets of generic arguments
    /// </summary>
    [Flags]
    public enum ParametricTarget : byte
    {
        None = 0,

        /// <summary>
        /// Indicates A generic argument targets a class
        /// </summary>
        Class = T.Class,

        /// <summary>
        /// Indicates A generic argument targets a struct
        /// </summary>
        Struct = T.Struct,

        /// <summary>
        /// Indicates A generic argument targets an interface
        /// </summary>
        Interface = T.Interface,

        /// <summary>
        /// Indicates A generic argument targets a delgate
        /// </summary>
        Delegate = T.Delegate,

        /// <summary>
        /// A generic argument applies to a type of some sort
        /// </summary>
        Type = Class | Interface | Struct | Delegate,

        /// <summary>
        /// Indicates A generic argument targets a method
        /// </summary>
        Method = 4,
    }
}