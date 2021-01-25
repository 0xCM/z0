//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ClrDynamic
    {
        public static MethodSlots<I> slots<I>(Type src)
            where I : unmanaged
                => new MethodSlots<I>(slots(src));

        [Op]
        public static Index<MethodSlot> slots(Type src)
        {
            var methods = @readonly(src.DeclaredMethods());
            var count = methods.Length;
            var buffer = memory.alloc<MethodSlot>(count);
            ref var dst = ref memory.first(buffer);
            for(var i=0; i<count; i++)
            {
                var method = skip(methods,i);
                RuntimeHelpers.PrepareMethod(method.MethodHandle);
                seek(dst,i) = new MethodSlot(method.Name, method.MethodHandle.GetFunctionPointer());
            }
            return buffer;
        }
    }
}
