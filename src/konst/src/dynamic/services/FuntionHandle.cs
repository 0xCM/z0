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

    public readonly struct FunctionHandle : IFunctionHandle
    {
        public static RuntimeMethodHandle from(DynamicMethod src)
        {
            var getMethodDescriptorInfo = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return (RuntimeMethodHandle)getMethodDescriptorInfo.Invoke(src, null);
        }

        [MethodImpl(Inline)]
        public static RuntimeMethodHandle from(MethodInfo src)
            => src.MethodHandle;

        [MethodImpl(Inline)]
        public static RuntimeMethodHandle from(Delegate src)
            => src.Method.MethodHandle;

        public static MethodBase from(RuntimeMethodHandle src)
            => MethodBase.GetMethodFromHandle(src);
    }
}