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
    /// Encloses a delegate that was manufactured dynamically
    /// </summary>
    public readonly struct DynamicDelegate
    {
        /// <summary>
        /// The delegate identity
        /// </summary>
        public readonly OpIdentity Id;

        /// <summary>
        /// The method invoked by the dynamic operator that provides the substance of the operation
        /// </summary>
        public readonly MethodInfo SourceMethod;

        /// <summary>
        /// The dynamically-generated method that backs the dynamic operator
        /// </summary>
        public readonly DynamicMethod TargetMethod;

        /// <summary>
        /// The dynamic operation
        /// </summary>
        public readonly Delegate DynamicOp;

        [MethodImpl(Inline)]
        public static DynamicDelegate Define(OpIdentity id, MethodInfo src, DynamicMethod dst, Delegate op)
            => new DynamicDelegate(id, src, dst, op);

        [MethodImpl(Inline)]
        DynamicDelegate(OpIdentity id, MethodInfo src, DynamicMethod dst, Delegate op)
        {
            this.Id = id;
            this.SourceMethod = src;
            this.TargetMethod = dst;
            this.DynamicOp = op;
        }

        /// <summary>
        /// Invokes the dynamic delegate dynamically
        /// </summary>
        /// <param name="args">The arguments to pass to the delegate</param>
        [MethodImpl(Inline)]
        public object Invoke(params object[] args)
            => DynamicOp.DynamicInvoke(args);

        /// <summary>
        /// The existing delegate, parametrically
        /// </summary>
        /// <typeparam name="D">The target delegate type</typeparam>
        [MethodImpl(Inline)]
        public DynamicDelegate<D> As<D>()
            where D : Delegate
                => new DynamicDelegate<D>(Id, SourceMethod, TargetMethod, (D)DynamicOp);
    }
}