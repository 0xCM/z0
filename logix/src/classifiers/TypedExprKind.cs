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

    public enum TypedExprKind : uint
    {
        
        /// <summary>
        /// Specifies a variable classification
        /// </summary>
        Variable,

        /// <summary>
        /// Identifies expression that depends on one or more variables
        /// </summary>
        Varied,

        /// <summary>
        /// Identifies a literal expression
        /// </summary>
        Literal,

        /// <summary>
        /// Classifies an operator 
        /// </summary>
        Operator,

        /// <summary>
        /// Classifies an identity
        /// </summary>
        Equality,


        /// <summary>
        /// Classifies a comparision
        /// </summary>
        Comparison,

        /// <summary>
        /// Classifies a shift expression
        /// </summary>
        ShiftExpr,
    }



}