//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using Windows;

    using static Root;
    using static core;

    partial struct Msg
    {
        public static MsgPattern<MemoryAddress> TraversingSegments => "Traversing memory segments above the process base address {0}";
    }

    public unsafe class SegmentTraverser : AppService<SegmentTraverser>
    {
        static bool readable(PageProtection src, MemState state)
            => (src == PageProtection.Readonly
            || src == PageProtection.ExecuteRead
            || src == PageProtection.ExecuteReadWrite
            || src == PageProtection.ReadWrite) && state == MemState.Committed;


        MemoryAddress ProcessBase;

        public SegmentTraverser()
        {
            ProcessBase = root.process().Handle.ToPointer();
        }

        public string Describe(in ProcessMemoryRegion region)
            => string.Format("[{0},{1}]({2})", region.StartAddress, region.StartAddress + region.Size, (ByteSize)region.Size);

        public ByteSize Traverse(ReadOnlySpan<ProcessMemoryRegion> src, FS.FolderPath outdir)
        {
            var count = src.Length;
            var accessible = 0u;
            var total = ByteSize.Zero;
            var flow = Wf.Running(Msg.TraversingSegments.Format(ProcessBase));

            for(var i=0; i<count; i++)
            {
                ref readonly var region = ref skip(src,i);
                var @base = region.StartAddress;
                if(@base < ProcessBase)
                    continue;

                if(readable(region.Protection, region.State))
                {
                    accessible++;
                    var dst = outdir + FS.file(string.Format("x{0}", @base.Format()), FS.Bin);
                    var emitting = Wf.EmittingFile(dst);
                    using var writer = dst.BinaryWriter();
                    var outsize = Emit(region, writer);
                    Wf.EmittedFile(emitting, (uint)outsize);
                    total += outsize;
                }

            }

            Wf.Ran(flow, string.Format("Traversed {0} bytes from {1} accessible regions", total, accessible));
            return total;
         }

        ByteSize Emit(in ProcessMemoryRegion src, BinaryWriter dst)
        {
            var description = src.Describe();
            var @base = src.StartAddress;
            var traversing = Wf.Running(string.Format("Traversing {0}", description));
            var reader = MemoryReader.create(@base.Pointer<byte>(), src.Size);
            var storage = z8;
            var traversed = ByteSize.Zero;
            while(reader.Read(ref storage))
            {
                dst.Write(storage);
                traversed++;
            }

            Wf.Ran(traversing, string.Format("Traversed {0} bytes from {1}", traversed, description));
            return traversed;
        }
    }
}