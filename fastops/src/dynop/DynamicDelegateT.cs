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

    using static zfunc;

    /// <summary>
    /// Encloses a generic delegate that was manufactured dynamically
    /// </summary>
    public readonly struct DynamicDelegate<D>
        where D : Delegate
    {
        [MethodImpl(Inline)]
        public static implicit operator DynamicDelegate(DynamicDelegate<D> src)
            => new DynamicDelegate(src.Id, src.SourceMethod, src.DynamicMethod, src.DynamicOp);

        [MethodImpl(Inline)]
        public static implicit operator D(DynamicDelegate<D> d)
            => d.DynamicOp;

        [MethodImpl(Inline)]
        public DynamicDelegate(OpIdentity id, MethodInfo src, DynamicMethod dst, D op)
        {
            this.Id = id;
            this.SourceMethod = src;
            this.DynamicOp = op;
            this.DynamicMethod = dst;
        }

        /// <summary>
        /// The delegate identity
        /// </summary>
        public readonly OpIdentity Id;

        /// <summary>
        /// The method invoked by the dynamic operator that provides the substance of the operation
        /// </summary>
        public readonly MethodInfo SourceMethod;

        /// <summary>
        /// The dynamic operation
        /// </summary>
        public readonly D DynamicOp;

        /// <summary>
        /// The dynamically-generated method that backs the dynamic operator
        /// </summary>
        public readonly DynamicMethod DynamicMethod;           
    }
}