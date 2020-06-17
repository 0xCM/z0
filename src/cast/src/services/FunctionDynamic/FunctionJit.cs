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

    public readonly struct FunctionJit : IFunctionJit
    {
        public static FunctionJit Service => default;

        [MethodImpl(Inline)]
        public static LocatedMethod jit(MethodInfo src)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            var location = (MemoryAddress)src.MethodHandle.GetFunctionPointer();
            return (src,location);            
        }

        [MethodImpl(Inline)]
        public static IntPtr jit(Delegate src)
        {   
            RuntimeHelpers.PrepareDelegate(src);
            return src.Method.MethodHandle.GetFunctionPointer();
        }    

        [MethodImpl(Inline)]
        public static DynamicPointer jit(DynamicDelegate src)
        {   
            RuntimeHelpers.PrepareDelegate(src.DynamicOp);
            return DynamicPointer.From(src);
        }        

        [MethodImpl(Inline)]
        public static DynamicPointer jit<D>(DynamicDelegate<D> src)
            where D : Delegate
                => jit(src.Untyped);
    }
}