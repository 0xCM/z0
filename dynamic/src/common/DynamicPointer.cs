//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Encloses a pointer to the native definition of a dynamic delegate
    /// </summary>
    public unsafe readonly struct DynamicPointer
    {
        [MethodImpl(Inline)]
        public static DynamicPointer Define(DynamicDelegate dynamicOp, IntPtr pointer)
            => new DynamicPointer(dynamicOp, pointer);

        [MethodImpl(Inline)]
        public DynamicPointer(DynamicDelegate dynamicOp, IntPtr pointer)
        {
            Ptr = pointer;
            Op = dynamicOp;
        }

        readonly DynamicDelegate Op;

        public readonly IntPtr Ptr;

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