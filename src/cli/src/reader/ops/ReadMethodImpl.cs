//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;
    using static memory;
    using static Images;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public MethodImplementation ReadMethodImpl(MethodImplementationHandle src)
            => MD.GetMethodImplementation(src);

        [MethodImpl(Inline), Op]
        public ref MethodImplementation ReadMethodImpl(MethodImplementationHandle src, ref MethodImplementation dst)
        {
            dst = ReadMethodImpl(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void ReadMethodImpls(ReadOnlySpan<MethodImplementationHandle> src, Span<MethodImplementation> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                ReadMethodImpl(skip(src,i), ref seek(dst,i));
        }
    }
}