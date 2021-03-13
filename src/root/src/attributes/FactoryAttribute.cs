//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a factory method which, by definition, is an emitter or a unary function
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class FactoryAttribute : OpAttribute
    {


    }
}