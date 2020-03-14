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

    using static Root;

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
        /// The dynamic operation
        /// </summary>
        public readonly Delegate DynamicOp;

        /// <summary>
        /// The dynamically-generated method that backs the dynamic operator
        /// </summary>
        public readonly DynamicMethod DynamicMethod;

        public static DynamicDelegate<D> Create<D>(DynamicMethod dst, OpIdentity id,  MethodInfo src)
            where D : Delegate
                => new DynamicDelegate<D>(id, src,dst, (D)dst.CreateDelegate(typeof(D)));

        public static DynamicDelegate Create(DynamicMethod dst, OpIdentity id, MethodInfo src, Type @delegate)
            => new DynamicDelegate(id, src, dst, dst.CreateDelegate(@delegate));

        [MethodImpl(Inline)]
        public static implicit operator Delegate(DynamicDelegate d)
            => d.DynamicOp;

        [MethodImpl(Inline)]
        public DynamicDelegate(OpIdentity id, MethodInfo src, DynamicMethod dst, Delegate op)
        {
            this.Id = id;
            this.SourceMethod = src;
            this.DynamicMethod = dst;
            this.DynamicOp = op;
        }



    }
}