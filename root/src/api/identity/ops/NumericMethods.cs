//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static Root;

    public static class NumericMethods
    {
        /// <summary>
        /// Determines whether a method has numeric operands (if any) and a numeric return type (if any)
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool test(MethodInfo m)
            => (m.HasVoidReturn() || NumericTypes.test(m.ReturnType)) 
             && m.ParameterTypes().All(t => NumericTypes.test(t));
    }
}