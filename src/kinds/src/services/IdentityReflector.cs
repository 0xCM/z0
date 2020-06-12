//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
 
    public readonly struct IdentityReflector : IIdentityReflector
    {
        public static IIdentityReflector Service => default(IdentityReflector);

        /// <summary>
        /// Returns true if all non-void input/output values are of the same type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public bool IsHomogenous(MethodInfo m)
        {
            var inputs = m.ParameterTypes().ToHashSet();
            if(inputs.Count == 1)
                return inputs.Single() == m.ReturnType;
            else if(inputs.Count == 0)
                return m.ReturnType == typeof(void);
            else
                return false;
        }
    }

    public partial interface IIdentityReflector : IStateless<IdentityReflector, IdentityReflector>
    {
        [MethodImpl(Inline)]
        bool IsHomogenous(MethodInfo m)
            => IdentityReflector.Service.IsHomogenous(m);    
    }
}