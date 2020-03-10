//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    using FC = FunctionClass;
    
    public enum MeasureClass : ulong
    {
        None = 0,

        /// <summary>
        /// Classifies a unary function that returns a numeric value
        /// </summary>
        UnaryMeasure = FC.UnaryMeasure,

        /// <summary>
        /// Classifies a homogenous binary function that returns a numeric value
        /// </summary>
        BinaryMeasure = FC.BinaryMeasure,

        /// <summary>
        /// Classifies a homogenous ternary function that returns a numeric value
        /// </summary>
        TernaryMeasure = FC.TernaryMeasure,
    }
}