//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Encloses a pointer to the native definition of a dynamic delegate
    /// </summary>
    public unsafe readonly struct DynamicPointer
    {
        [MethodImpl(Inline)]
        public static DynamicPointer From(DynamicDelegate src)
        {
            var ptr = src.DynamicMethod.NativePointer();
            return new DynamicPointer(src, (byte*)ptr.ToPointer());
        }

        [MethodImpl(Inline)]
        public static DynamicPointer From<D>(DynamicDelegate<D> src)
            where D : Delegate
        {
            var ptr = src.DynamicMethod.NativePointer();
            return new DynamicPointer(src, (byte*)ptr.ToPointer());
        }

        [MethodImpl(Inline)]
        public DynamicPointer(DynamicDelegate dynamicOp, byte* pointer)
        {
            Pointer = pointer;
            Op = dynamicOp;
        }

        readonly DynamicDelegate Op;

        public readonly byte* Pointer;

        public Delegate DynamicOp 
            => Op.DynamicOp;
        public MethodInfo SourceMethod
            => Op.SourceMethod;

        public MethodInfo DynamicMethod
            => Op.DynamicMethod;
    }
}