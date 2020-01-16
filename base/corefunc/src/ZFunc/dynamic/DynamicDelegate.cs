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

    /// <summary>
    /// Encloses a generic delegate that was manufactured dynamically
    /// </summary>
    public readonly struct DynamicDelegate<D>
        where D : Delegate
    {
        [MethodImpl(Inline)]
        public static implicit operator DynamicDelegate(DynamicDelegate<D> d)
            => new DynamicDelegate(d.SourceMethod, d.DynamicMethod, d.DynamicOp);

        [MethodImpl(Inline)]
        public static implicit operator D(DynamicDelegate<D> d)
            => d.DynamicOp;

        [MethodImpl(Inline)]
        public DynamicDelegate(MethodInfo src, DynamicMethod dst, D op)
        {
            this.SourceMethod = src;
            this.DynamicOp = op;
            this.DynamicMethod = dst;
        }

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
           
        /// <summary>
        /// Imagines a D-delegate as an S-delegate
        /// </summary>
        /// <typeparam name="S">The target delegate type</typeparam>
        [MethodImpl(Inline)]
        public DynamicDelegate<S> As<S>()
            where S : Delegate
                => DynamicDelegate.Define(SourceMethod, DynamicMethod, Unsafe.As<D,S>(ref Unsafe.AsRef(in this.DynamicOp)));
    }
}