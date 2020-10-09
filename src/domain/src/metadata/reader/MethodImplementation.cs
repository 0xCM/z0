//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Konst;
    using static z;
    using static ClrData;

    partial class ImageMemoryMap
    {
        [MethodImpl(Inline), Op]
        public MethodImplementation Read(MethodImplementationHandle src)
            => Reader.GetMethodImplementation(src);

        [MethodImpl(Inline), Op]
        public ref MethodImplementation Read(MethodImplementationHandle src, ref MethodImplementation dst)
        {
            dst = Read(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void Read(ReadOnlySpan<MethodImplementationHandle> src, Span<MethodImplementation> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                Read(skip(src,i), ref seek(dst,i));
        }
    }
}