//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class TypeId
    {
        /// <summary>
        /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a numeric type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static TypeIdentity numeric<T>(T t = default)
            where T : unmanaged
                => TypeIdentity.Define(typeof(T).NumericKind().Format());
    }
}