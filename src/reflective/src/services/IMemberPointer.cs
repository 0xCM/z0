//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct MemberPointer : IMemberPointer
    {
        public static IMemberPointer Service => default(MemberPointer);
    }

    public interface IMemberPointer : IService
    {        
        [MethodImpl(Inline)]
        DynamicPointer Pointer(DynamicDelegate src)
            => Delegates.pointer(src);

        [MethodImpl(Inline)]
        DynamicPointer Pointer<D>(DynamicDelegate<D> src)
            where D : Delegate
                => Delegates.pointer(src);
    }
}