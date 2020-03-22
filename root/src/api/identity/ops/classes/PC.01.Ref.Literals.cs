//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using PC = ParameterClass;

    public enum ParamRefAspect : uint
    {
        /// <summary>
        /// The empty class
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies paramters that are declared with the "in" modifier
        /// </summary>
        In = PC.In,

        /// <summary>
        /// Classifies paramters that are declared with the "out" modifier
        /// </summary>
        Out = PC.Out,

        /// <summary>
        /// Classifies paramters that are declared with the "ref" modifier
        /// </summary>
        Ref = PC.Ref,
    }    
}