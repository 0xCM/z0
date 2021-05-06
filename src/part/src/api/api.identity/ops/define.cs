//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial struct ApiIdentity
    {
        /// <summary>
        /// Creates an identity predicated on an api class and parametric type
        /// </summary>
        /// <param name="k">The api classifier</param>
        /// <param name="generic">Whether a generic identity should be produced</param>
        /// <typeparam name="K">The api class type</typeparam>
        /// <typeparam name="T">The parameter type</typeparam>
        public static OpIdentity define<K,T>(K k, bool generic)
            where K : unmanaged, IApiClass
                => ApiIdentityBuilder.build(k.ClassId, Numeric.kind<T>(), generic);
    }
}