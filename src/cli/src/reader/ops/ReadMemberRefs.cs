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
        public ref MemberRef ReadMemberRef(MemberReferenceHandle handle, ref MemberRef dst)
        {
            var src = MD.GetMemberReference(handle);
            dst.Token = Clr.token(handle);
            dst.Name = MD.GetString(src.Name);
            dst.Parent = Clr.token(src.Parent);
            dst.RefKind = (MemberRefKind)src.GetKind();
            dst.Sig = MD.GetBlobBytes(src.Signature);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void ReadMemberRefs(ReadOnlySpan<MemberReferenceHandle> src, Span<MemberRef> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                ReadMemberRef(skip(src,i), ref seek(dst,i));
        }

        public ReadOnlySpan<MemberRef> ReadMemberRefs()
        {
            var handles = MemberRefHandles;
            var dst = alloc<MemberRef>(handles.Length);
            ReadMemberRefs(handles,dst);
            return dst;
        }
    }
}