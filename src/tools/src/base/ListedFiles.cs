//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    using Z0.Data;

    using F = ListedFileField;

    public readonly struct ListedFiles
    {
        public static string format(in ListedFiles src)
        {
            var dst = text.build();
            render(src,dst);
            return dst.ToString();
        }

        public static void render(in ListedFiles src, FilePath dst)
        {
            var records = z.span(src.Data);
            var count = records.Length;
            var header = Table.header<F>();
            using var writer = dst.Writer();
            writer.WriteLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref src[i];
                writer.WriteLine(render(record));
            }    
        }

        public static void render(in ListedFiles src, StringBuilder dst)
        {
            var records = z.span(src.Data);
            var count = records.Length;
            var header = Table.header<F>();
            dst.AppendLine(header.HeaderText);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref src[i];
                dst.AppendLine(render(record));
            }    
        }
        
        public static string render(in ListedFile src)
            => text.format("{0,-10} | {1}", src.Index, src.Path);

        public static ListedFiles from(FilePath[] src)        
            => new ListedFiles(src.Map(Files.normalize).Mapi((i, x) => new ListedFile((uint)i,x.Name)));

        public static ListedFiles from<T,F>(ToolFiles<T,F> src)   
            where T : struct, ITool<T>
            where F : unmanaged, Enum  
        {   
            var view = src.View;
            var buffer = sys.alloc<ListedFile>(src.Count);
            var dst = z.span(buffer);
            for(var i=0u; i<src.Count; i++)
                z.seek(dst,i) = new ListedFile(i, z.skip(view,i).Path.Name);
            return buffer;
        }

        public static ListedFiles from(Files src)        
            => new ListedFiles(src.Data.Mapi((i,x) => new ListedFile((uint)i,x.Name)));

        public readonly ListedFile[] Data;

        [MethodImpl(Inline)]
        public ListedFiles(ListedFile[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public ref readonly ListedFile this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator ListedFiles(ListedFile[] src)
            => new ListedFiles(src);
    }
}