//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Reflection;
    
    using static Root;

    /// <summary>
    /// Defines a stateless composed context
    /// </summary>
    public readonly struct ComposedContext : IComposedContext
    {
        [MethodImpl(Inline)]
        internal ComposedContext(int id, IAssemblyComposition composition)
        {
            this.Identity = id;
            this.Compostion = composition;
        }

        /// <summary>
        /// Uniquely identifies the context within an application domain
        /// </summary>
        public readonly int Identity;

        /// <summary>
        /// The assigned composition
        /// </summary>
        public IAssemblyComposition Compostion {get;}
    }

    /// <summary>
    /// Defines a stateful composed context
    /// </summary>
    public readonly struct ComposedContext<S> : IComposedContext<ComposedContext<S>,S>
    {
        [MethodImpl(Inline)]
        internal ComposedContext(int id, S state, IAssemblyComposition composition)
        {
            this.Identity = id;
            this.State = state;
            this.Compostion = composition;
        }

        /// <summary>
        /// Uniquely identifies the context within an application domain
        /// </summary>
        public readonly int Identity;

        /// <summary>
        /// The context state
        /// </summary>
        public readonly S State;

        S IContext<S>.State 
            => State;

        /// <summary>
        /// The assigned composition
        /// </summary>
        public IAssemblyComposition Compostion {get;}
    }
}