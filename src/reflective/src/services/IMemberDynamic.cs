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

    public readonly struct MemberDynamic : IMemberDynamic
    {
        public static IMemberDynamic Service => default(MemberDynamic);
    }
    
    public interface IMemberDynamic : IMemberCil, IMemberPointer, IMemberJit  
    {
        RuntimeMethodHandle handle(DynamicMethod src)
            => DynamicOps.handle(src);
        
        MethodBase method(RuntimeMethodHandle src)
            => MethodBase.GetMethodFromHandle(src);
    }
}