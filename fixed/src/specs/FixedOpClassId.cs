//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FixedWidth;
    using FT = FixedTypeKind;

    using FC = FixedOpClass;
    using ID = OperationClassId;


    public enum FixedOpClassId : ushort
    {
        /// <summary>
        /// The identity that identifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies fixed actions
        /// </summary>        
        FixedAction = FC.FixedAction,

        /// <summary>
        /// Classifies fixed functions
        FixedFunction= FC.FixedFunction,

        /// <summary>
        /// Classifies fixed operators
        /// </summary>        
        FixedOperator = FC.FixedOperator,

        /// <summary>
        /// Classifies fixed predicates
        /// </summary>        
        FixedPredicate = FC.FixedPredicate,

        /// <summary>
        /// Specifies the upper numeric bound for fixed operaton class identity
        /// </summary>        
        LastIdentity = FC.LastClass,       
    }
}