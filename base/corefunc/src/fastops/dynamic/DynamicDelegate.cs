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
        public static DynamicDelegate<D> Define<D>(MethodInfo src, DynamicMethod dst, D op)
            where D : Delegate
                => new DynamicDelegate<D>(src, dst,op);

        [MethodImpl(Inline)]
        public static DynamicDelegate Define(MethodInfo src, DynamicMethod dst, Delegate op)
            => new DynamicDelegate(src, dst,op);

        [MethodImpl(Inline)]
        public static implicit operator Delegate(DynamicDelegate d)
            => d.DynamicOp;

        [MethodImpl(Inline)]
        public DynamicDelegate(MethodInfo src, DynamicMethod dst, Delegate op)
        {
            this.SourceMethod = src;
            this.DynamicMethod = dst;
            this.DynamicOp = op;
        }

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

        /// <summary>
        /// Imagines an untyped delegate as a D-delegate
        /// </summary>
        /// <typeparam name="D">The target delegate type</typeparam>
        [MethodImpl(Inline)]
        public DynamicDelegate<D> As<D>()
            where D : Delegate
                => DynamicDelegate.Define(SourceMethod, DynamicMethod, Unsafe.As<Delegate,D>(ref Unsafe.AsRef(in this.DynamicOp)));
    }
}