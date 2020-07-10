//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using T = GenericTargetKind;
    using S = GenericStateKind;

    [Flags]
    public enum GenericityClass : byte
    {
        None  = 0,

        /// <summary>
        /// Indicates generic argument applies to a method
        /// </summary>
        Type = T.Type,

        /// <summary>
        /// Indicates generic argument applies to a method
        /// </summary>
        Method = T.Method,

        /// <summary>
        /// Indicates subject is a generic defintion
        /// </summary>
        Definition = S.Definition,

        /// <summary>
        /// Indicates subject is open generic
        /// </summary>
        Open = S.Open,

        /// <summary>
        /// Indicates subject is closed generic
        /// </summary>
        Closed = S.Closed,

        /// <summary>
        /// Designates a generic type definition
        /// </summary>
        TypeDefinition = T.Type | S.Definition,

        /// <summary>
        /// Designates a generic method definition
        /// </summary>
        MethodDefinition = T.Method | S.Definition,

        /// <summary>
        /// Designates an open generic type
        /// </summary>
        OpenType = T.Type | S.Open,

        /// <summary>
        /// Designates an open generic method
        /// </summary>
        OpenMethod = T.Method | S.Open,

        /// <summary>
        /// Designates a closed generic type
        /// </summary>
        ClosedType = T.Type | S.Closed,

        /// <summary>
        /// Designates a closed generic method
        /// </summary>
        ClosedMethod = T.Method | S.Closed
    }
}