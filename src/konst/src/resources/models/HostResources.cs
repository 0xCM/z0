//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines the content of a set of binary resources for an api host
    /// </summary>
    public readonly struct HostResources
    {
        public readonly ApiHostUri Host;                

        public readonly BinaryResourceSpec[] Data;

        [MethodImpl(Inline)]
        public HostResources(ApiHostUri host, BinaryResourceSpec[] resources)
        {
            Host = host;
            Data = resources;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly BinaryResourceSpec this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}