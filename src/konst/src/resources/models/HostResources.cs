//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines the content of a set of binary resources for an api host
    /// </summary>
    public readonly struct HostResources
    {
        public static HostResources from(ApiHexIndex src)
        {
            var count = src.Code.Length;
            var buffer = alloc<BinaryResourceSpec>(count);
            var dst = span(buffer);
            var blocks = span(src.Code);
            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref skip(blocks,i);
                var name = LegalIdentityBuilder.code(code.Id);
                seek(dst,i) = new BinaryResourceSpec(name, code.Encoded);
            }
            return new HostResources(src.Host, buffer);
        }

        public readonly ApiHostUri Host;

        public readonly BinaryResourceSpec[] Data;

        [MethodImpl(Inline)]
        public HostResources(ApiHostUri host, BinaryResourceSpec[] src)
        {
            Host = host;
            Data = src;
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