//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Encloses a generic delegate that was manufactured dynamically
    /// </summary>
    public readonly struct DynamicDelegate<D> : IIdentified<OpIdentity>
        where D : Delegate
    {
        /// <summary>
        /// The delegate identity
        /// </summary>
        public OpIdentity Id {get;}

        /// <summary>
        /// The method invoked by the dynamic operator that provides the substance of the operation
        /// </summary>
        public readonly MethodInfo Source;

        /// <summary>
        /// The dynamically-generated method that backs the dynamic operator
        /// </summary>
        public readonly DynamicMethod Target;

        /// <summary>
        /// The dynamic operation
        /// </summary>
        public readonly D DynamicOp;

        [MethodImpl(Inline)]
        public DynamicDelegate(OpIdentity id, MethodInfo src, DynamicMethod dst, D op)
        {
            Id = id;
            Source = src;
            Target = dst;
            DynamicOp = op;
        }

        public DynamicDelegate Untyped
        {
            [MethodImpl(Inline)]
            get => DynamicDelegate.define(Id, Source, Target, DynamicOp);
        }
    }
}