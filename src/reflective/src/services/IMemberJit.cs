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

    using static Seed;

    public readonly struct MemberJit : IMemberJit
    {
        public static MemberJit Service => default(MemberJit);

        [MethodImpl(Inline)]
        public IntPtr Jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            return src.MethodHandle.GetFunctionPointer();
        }

        [MethodImpl(Inline)]
        public IntPtr Jit(Delegate src)
        {   
            RuntimeHelpers.PrepareDelegate(src);
            return src.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        public DynamicPointer Jit(DynamicDelegate src)
        {   
            RuntimeHelpers.PrepareDelegate(src.DynamicOp);
            return DynamicPointer.From(src);
        }        

        [MethodImpl(Inline)]
        public DynamicPointer Jit<D>(DynamicDelegate<D> src)
            where D : Delegate
                => Jit(src.Untyped);
    }
    
    public interface IMemberJit : IService
    {
        [MethodImpl(Inline)]
        IntPtr Jit(MethodInfo src)
            => MemberJit.Service.Jit(src);

        [MethodImpl(Inline)]
        IntPtr Jit(Delegate src)
            => MemberJit.Service.Jit(src);

        [MethodImpl(Inline)]
        DynamicPointer Jit(DynamicDelegate src)
            => MemberJit.Service.Jit(src);

        [MethodImpl(Inline)]
        DynamicPointer Jit<D>(DynamicDelegate<D> src)            
            where D : Delegate
                => MemberJit.Service.Jit(src);
    }
}