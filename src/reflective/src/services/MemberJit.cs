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

    public interface IMemberJit : IStateless<MemberJit,IMemberJit>
    {
        [MethodImpl(Inline)]
        IntPtr Jit(MethodInfo src)
            => DynamicOps.jit(src);

        [MethodImpl(Inline)]
        IntPtr Jit(Delegate src)
            => DynamicOps.jit(src);           

        [MethodImpl(Inline)]
        DynamicPointer Jit(DynamicDelegate src)
            => DynamicOps.jit(src);

        [MethodImpl(Inline)]
        DynamicPointer Jit<D>(DynamicDelegate<D> d)            
            where D : Delegate
                => DynamicOps.jit(d);        
    }

    public readonly struct MemberJit : IMemberJit
    {

    }
}