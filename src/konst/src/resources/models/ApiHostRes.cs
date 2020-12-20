//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines the content of a set of binary resources for an api host
    /// </summary>
    public readonly struct ApiHostRes
    {
        public ApiHostUri Host {get;}

        public BinaryResSpec[] Data {get;}

        [MethodImpl(Inline)]
        public ApiHostRes(ApiHostUri host, BinaryResSpec[] src)
        {
            Host = host;
            Data = src;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly BinaryResSpec this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}