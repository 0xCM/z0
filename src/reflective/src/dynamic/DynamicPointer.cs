//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Encloses a pointer to the native definition of a dynamic delegate
    /// </summary>
    public unsafe readonly struct DynamicPointer
    {
        readonly DynamicDelegate Op;

        public readonly IntPtr Ptr;

        [MethodImpl(Inline)]
        public static DynamicPointer Define(DynamicDelegate d, IntPtr pointer)
            => new DynamicPointer(d, pointer);

        [MethodImpl(Inline)]
        public static DynamicPointer Define<D>(DynamicDelegate<D> d, IntPtr pointer)
            where D : Delegate
                => Define(d.Untyped, pointer);

        [MethodImpl(Inline)]
        public DynamicPointer(DynamicDelegate dynamicOp, IntPtr pointer)
        {
            Ptr = pointer;
            Op = dynamicOp;
        }

        public byte* BytePtr
        {
            [MethodImpl(Inline)]
            get => Ptr.ToPointer<byte>();
        }
        
        public Delegate DynamicOp 
            => Op.DynamicOp;
        
        public MethodInfo SourceMethod
            => Op.SourceMethod;

        public MethodInfo DynamicMethod
            => Op.TargetMethod;
    }
}