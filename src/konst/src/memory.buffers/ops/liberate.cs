//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    unsafe partial struct Buffers
    {
        [MethodImpl(Inline)]
        public static unsafe ref readonly Ref<T> liberate<T>(in Ref<T> src)
            where T : unmanaged
        {
            memory.liberate(src.BaseAddress.Pointer<T>(), (int)src.DataSize);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref readonly BinaryCode liberate(in BinaryCode src)
        {
            liberate<byte>(src.Ref);
            return ref src;
        }
    }
}