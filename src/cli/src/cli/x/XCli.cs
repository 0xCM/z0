//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static memory;


    public static partial class XCli
    {
        [MethodImpl(Inline)]
        public static CliHandleData Data(this Handle src)
            => Cli.data(src);

        [MethodImpl(Inline)]
        public static bool IsValid(this CliTableKind src)
            => src != CliTableKind.Invalid;

        [MethodImpl(Inline)]
        public static void IfValid(this CliTableKind src, Action f)
        {
            if(src.IsValid())
                f();
        }

        [MethodImpl(Inline)]
        public static T MapValid<S,T>(this CliTableKind src, S input, Func<S,T> f, Func<T> @else)
            => src.IsValid() ? f(input) : @else();


        // public static string PeekUtf8(int offset, int byteCount)
        // {
        //     CheckBounds(offset, byteCount);
        //     return Encoding.UTF8.GetString(Pointer + offset, byteCount);
        // }


        // public static MemoryBlock GetMetadataBlock(this MetadataReader reader, HeapIndex heapIndex)
        // {
        //     return heapIndex switch
        //     {
        //         HeapIndex.UserString => reader.UserStringHeap.Block,
        //         HeapIndex.String => reader.StringHeap.Block,
        //         HeapIndex.Blob => reader.BlobHeap.Block,
        //         HeapIndex.Guid => reader.GuidHeap.Block,
        //         _ => throw new ArgumentOutOfRangeException("heapIndex"),
        //     };
        // }
    }
}