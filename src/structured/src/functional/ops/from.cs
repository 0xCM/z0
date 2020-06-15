//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial struct Functional
    {
        /// <summary>
        /// Creates a provider from the service factory that defines operations to instantiate
        /// services and an enclosing type within which the service implementations are defined
        /// </summary>
        /// <param name="factory">The service factor</param>
        /// <param name="enclosure">The outer host type</param>
        [MethodImpl(Inline), Op]
        public static IFunctional from(Type factory, Type enclosure)
            => new Functional(factory, enclosure);

        [MethodImpl(Inline)]
        public static IFunctional<S> from<S>()
            where S : IFunctional<S>, new()
                => default(Functional<S>);

        /// <summary>
        /// Creates a functional predicated on parametric factory and host enclosure types
        /// </summary>
        /// <typeparam name="F">The factory type</typeparam>
        /// <typeparam name="H">The host enclosure type</typeparam>
        [MethodImpl(Inline)]
        public static IFunctional<F,H> from<F,H>()
            where F : IFunctional<F,H>, new()
                => default(Functional<F,H>);
    }
}