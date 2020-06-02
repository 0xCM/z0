//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Identifies a factory method which, by definition, is an emitter or a unary function
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class FactoryAttribute : OpAttribute
    {


    } 

    /// <summary>
    /// Identifies a referentially-transparent method that produces literal values, structural values or sequences of such values
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ConstAttribute : OpAttribute
    {

    }
}