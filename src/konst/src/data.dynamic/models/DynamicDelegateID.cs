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
    public readonly struct DynamicDelegate<I,D> : IIdentified<I>
        where I : struct, IIdentified<I>
        where D : Delegate
    {
        /// <summary>
        /// The delegate identity
        /// </summary>
        public I Id {get;}

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
        public DynamicDelegate(I id, MethodInfo src, DynamicMethod dst, D op)
        {
            Id = id;
            Source = src;
            Target = dst;
            DynamicOp = op;
        }
    }
}