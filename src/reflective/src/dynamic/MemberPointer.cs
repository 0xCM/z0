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

    public interface IMemberPointer : IStateless<MemberPointer, IMemberPointer>
    {        
        [MethodImpl(Inline)]
        DynamicPointer Pointer(DynamicDelegate src)
            => DynamicOps.pointer(src);
        
        [MethodImpl(Inline)]
        DynamicPointer Pointer<D>(DynamicDelegate<D> src)
            where D : Delegate
                => DynamicOps.pointer(src);
    }

    public readonly struct MemberPointer : IMemberPointer
    {

    }
}