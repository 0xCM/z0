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
    public readonly struct HostResourceSpec
    {
        public readonly ApiHostUri Host;                

        public readonly BinaryResourceSpec[] Resources;

        [MethodImpl(Inline)]
        public HostResourceSpec(ApiHostUri host, BinaryResourceSpec[] resources)
        {
            Host = host;
            Resources = resources;
        }
        public int Count
        {
            [MethodImpl(Inline)]
            get => Resources.Length;
        }

        public ref readonly BinaryResourceSpec this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Resources[index];
        }
    }
}