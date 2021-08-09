//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct ApiCodeRes
    {
        public ApiHostKey Host {get;}

        public Index<BinaryResSpec> Data {get;}

        [MethodImpl(Inline)]
        public ApiCodeRes(ApiHostKey key, BinaryResSpec[] src)
        {
            Host = key;
            Data = src;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public ref readonly BinaryResSpec this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public static ApiCodeRes Empty
            => new ApiCodeRes(ApiHostKey.Empty, array<BinaryResSpec>());
    }
}