//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct Resources
    {

        [Op]
        static MemoryAddress fptr(MethodInfo src)
            => src.MethodHandle.GetFunctionPointer();

        [Op]
        static MemoryAddress jit(MethodInfo src)
        {
            sys.prepare(src.MethodHandle);
            return fptr(src);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> definition(ApiResAccessor src)
        {
            const byte size = 29;
            var cell = Cells.alloc(w256);
            var storage = cell.Bytes;
            var data = cover<byte>(jit(src.Member), size);
            for(var i=0; i<size; i++)
                seek(storage,i) = skip(data,i);
            return slice(data,0,size);
        }

        [MethodImpl(Inline), Op]
        public static unsafe ApiRes load(ApiResAccessor src)
        {
            var data = description(src);
            var address = slice(data,8,8).TakeUInt64();
            var size = slice(data,22,4).TakeUInt32();
            return new ApiRes(src, address, size);
        }

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> description(ApiResAccessor src, byte size = 29)
            => cover<byte>(jit(src.Member), size);
    }
}