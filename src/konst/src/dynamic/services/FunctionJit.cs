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
        [MethodImpl(Inline)]
        public static LocatedMethod jit(MethodInfo src, int? size = null)
        {
            RuntimeHelpers.PrepareMethod(src.MethodHandle);
            var location = (MemoryAddress)src.MethodHandle.GetFunctionPointer();
            return  new LocatedMethod(OpIdentity.Empty, src, location, size);
        }

        [MethodImpl(Inline)]
        public static LocatedMethod jit(IdentifiedMethod src)
        {
            RuntimeHelpers.PrepareMethod(src.Method.MethodHandle);
            var location = (MemoryAddress)src.Method.MethodHandle.GetFunctionPointer();
            return new LocatedMethod(src.Id, src.Method, location);
        }

        /// <summary>
        /// Jits the method declared by a specified type
        /// </summary>
        /// <param name="src">The source type</param>
        public static LocatedMethod[] jit(Type src)
            => src.DeclaredMethods().Select(m => FunctionJit.jit(m, FunctionInfo.size(m)));

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