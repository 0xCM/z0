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

    using static Part;

    partial struct ClrDynamic
    {
        [MethodImpl(Inline), Op]
        public static RuntimeMethodHandle handle(DynamicMethod src)
        {
            var getMethodDescriptorInfo = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return (RuntimeMethodHandle)getMethodDescriptorInfo.Invoke(src, null);
        }

        [MethodImpl(Inline), Op]
        public static RuntimeMethodHandle handle(MethodInfo src)
            => src.MethodHandle;

        [MethodImpl(Inline), Op]
        public static RuntimeMethodHandle handle(Delegate src)
            => src.Method.MethodHandle;
    }
}