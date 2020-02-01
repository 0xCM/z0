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
    /// Encloses a delegate that was manufactured dynamically
    /// </summary>
    public readonly struct DynamicDelegate
    {
        [MethodImpl(Inline)]
        public static DynamicDelegate<D> Define<D>(Moniker id, MethodInfo src, DynamicMethod dst, D op)
            where D : Delegate
                => new DynamicDelegate<D>(id, src, dst,op);

        [MethodImpl(Inline)]
        public static DynamicDelegate Define(Moniker id, MethodInfo src, DynamicMethod dst, Delegate op)
            => new DynamicDelegate(id,src, dst,op);

        [MethodImpl(Inline)]
        internal static DynamicDelegate From<D>(DynamicDelegate<D> src)
            where D : Delegate
                => new DynamicDelegate(src.Id,src.SourceMethod, src.DynamicMethod,src.DynamicOp);

        [MethodImpl(Inline)]
        public static implicit operator Delegate(DynamicDelegate d)
            => d.DynamicOp;

        [MethodImpl(Inline)]
        DynamicDelegate(Moniker id, MethodInfo src, DynamicMethod dst, Delegate op)
        {
            this.Id = id;
            this.SourceMethod = src;
            this.DynamicMethod = dst;
            this.DynamicOp = op;
        }

        /// <summary>
        /// The delegate identity
        /// </summary>
        public readonly Moniker Id;

        /// <summary>
        /// The method invoked by the dynamic operator that provides the substance of the operation
        /// </summary>
        public readonly MethodInfo SourceMethod;

        /// <summary>
        /// The dynamic operation
        /// </summary>
        public readonly Delegate DynamicOp;

        /// <summary>
        /// The dynamically-generated method that backs the dynamic operator
        /// </summary>
        public readonly DynamicMethod DynamicMethod;
    }
}