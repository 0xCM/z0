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

    public readonly struct MemberHandle : IMemberHandle
    {
        public static IMemberHandle Service => default(MemberHandle);
    }

    public interface IMemberHandle
    {
        RuntimeMethodHandle Handle(DynamicMethod src)
        {
            var getMethodDescriptorInfo = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return (RuntimeMethodHandle)getMethodDescriptorInfo.Invoke(src, null);
        }

        [MethodImpl(Inline)]
        RuntimeMethodHandle Handle(MethodInfo src)
            => src.MethodHandle;

        [MethodImpl(Inline)]
        RuntimeMethodHandle Handle(Delegate src)
            => src.Method.MethodHandle;        

        MethodBase Method(RuntimeMethodHandle src)
            => MethodBase.GetMethodFromHandle(src);            
    }
}