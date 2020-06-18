//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// For a non-constructed generic method or a generic method definition, returns an array of the method's type parameters; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] OpenTypeParameters(this MethodInfo m, bool effective)
            => (m.ContainsGenericParameters ? m.GetGenericMethodDefinition().GetGenericArguments()
             : m.IsGenericMethodDefinition ? m.GetGenericArguments()
             : Array.Empty<Type>()).Select(arg => effective ? arg.TEffective() : arg).ToArray();
    }
}