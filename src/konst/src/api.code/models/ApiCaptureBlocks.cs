//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct ApiCaptureBlocks : IIndex<ApiCaptureBlock>
    {

        [MethodImpl(Inline), Op]
        public static Pair<ByteSize> sizes(ReadOnlySpan<ApiCaptureBlock> src)
        {
            var input = ByteSize.Zero;
            var output = ByteSize.Zero;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                input += block.InputSize;
                output += block.OutputSize;
            }
            return (input,output);
        }

        readonly Index<ApiCaptureBlock> Data;

        [MethodImpl(Inline)]
        public ApiCaptureBlocks(Index<ApiCaptureBlock> src)
        {
            Data = src;
        }

        public Span<ApiCaptureBlock> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<ApiCaptureBlock> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ApiCaptureBlock[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ByteSize ExtractSize
            => sizes(Data).Left;

        public ByteSize ParsedSize
            => sizes(Data).Right;

        public ref readonly ApiCaptureBlock First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public ref readonly ApiCaptureBlock Last
        {
            [MethodImpl(Inline)]
            get => ref Data.Last;
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiCaptureBlocks(ApiCaptureBlock[] src)
            => new ApiCaptureBlocks(src);

        [MethodImpl(Inline)]
        public static implicit operator ApiCaptureBlock[](ApiCaptureBlocks src)
            => src.Storage;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<ApiCaptureBlock>(ApiCaptureBlocks src)
            => src.View;
    }
}