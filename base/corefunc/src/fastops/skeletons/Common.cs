//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;
    
    using static zfunc;

    public static partial class OpSkeleta
    {
        public abstract class Op<A> : IFunc
        {
            protected abstract string GetOpName();

            public virtual OpIdentity Moniker => Identity.operation<A>(GetOpName());
        }

        /// <summary>
        /// Base type for homogenous vectorized operators
        /// </summary>
        /// <typeparam name="W">The vector bit width</typeparam>
        /// <typeparam name="V">The vector type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VOp<W,V,T> : Op<V>
            where W : unmanaged, ITypeNat
            where V : struct
            where T : unmanaged
        {
            protected static W w => default;

            protected static T t => default;

            public override OpIdentity Moniker => Identity.operation<W,T>(GetOpName());
        }
    }
}