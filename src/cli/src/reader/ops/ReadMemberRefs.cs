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
    using static ImageRecords;

    partial class ImageMetaReader
    {
        public ref MemberRefRow ReadMemberRef(MemberReferenceHandle handle, ref MemberRefRow dst)
        {
            var src = MD.GetMemberReference(handle);
            dst.Token = CliTokens.token(handle);
            dst.Name = MD.GetString(src.Name);
            dst.Parent = CliTokens.token(src.Parent);
            dst.RefKind = (MemberRefKind)src.GetKind();
            dst.Sig = MD.GetBlobBytes(src.Signature);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public void ReadMemberRefs(ReadOnlySpan<MemberReferenceHandle> src, Span<MemberRefRow> dst)
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                ReadMemberRef(skip(src,i), ref seek(dst,i));
        }

        public ReadOnlySpan<MemberRefRow> ReadMemberRefs()
        {
            var handles = MemberRefHandles;
            var dst = alloc<MemberRefRow>(handles.Length);
            ReadMemberRefs(handles,dst);
            return dst;
        }
    }
}