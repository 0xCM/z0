//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    public enum LogicExprKind : uint
    {
        
        /// <summary>
        /// Classifies a boolean variable
        /// </summary>
        Variable,

        /// <summary>
        /// Classifies a boolean expression that depends on one or more variables
        /// </summary>
        Varied,

        /// <summary>
        /// Classifies a boolean literal
        /// </summary>
        Literal,

        /// <summary>
        /// Classifies a logical operator
        /// </summary>
        Operator,

        /// <summary>
        /// Classifies a logical identity
        /// </summary>
        Equality
    }




}