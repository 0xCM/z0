//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct LlvmTypes
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public struct dag<T> : IDag<dag<T>>
            where T : unmanaged, IDag
        {
            public T Def;

            [MethodImpl(Inline)]
            public dag(T def)
            {
                Def = def;
            }

            public uint StorageSize
            {
                [MethodImpl(Inline)]
                get => size<dag<T>>();
            }
        }
    }
}