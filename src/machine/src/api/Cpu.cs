//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;
    using Z0.Asm.Data;

    using static Konst;
    using static Memories;

    readonly struct AsmParseCases
    {
        public const string Case01 = "002ch vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}";
    }

    [ApiHost]
    public class Cpu
    {
        const int DefaultBufferSize = CpuBuffer.BufferSize;

        readonly IMachineContext Context;

        readonly CpuBuffers Buffers;

        readonly List<AsmSourceDoc> AsmDocs;

        int Count;

        readonly MachineFiles Files;

        [MethodImpl(Inline), Op]
        public static Cpu alloc(IMachineContext context)
            => new Cpu(context, 0);

        [MethodImpl(Inline)]
        internal Cpu(IMachineContext context, int runidx)
        {
            AsmDocs = new List<AsmSourceDoc>(100);
            Context = context;
            Files = MachineFiles.Service(context);
            Buffers = CpuBuffers.Alloc(DefaultBufferSize);
            Count = runidx;
        }

        void AddAsmDoc(FilePath src, TextDoc doc)
        {
            var parser = AsmDocParser.Service;
            var blocks = parser.Parse(doc);
            if(blocks)
                AsmDocs.Add(new AsmSourceDoc(src,doc,blocks.Value));            
        }

        void LoadAsmDoc(FilePath src)
        {
            src.ReadTextDoc().OnSome(doc => AddAsmDoc(src,doc));
        }
        
        void LoadAsmDocs()
        {
            Root.iter(Files.Archive.AsmFiles,LoadAsmDoc);
            Notify(CpuEvent.Create("Loaded asm docs", AsmDocs.Count));
        }

        [Op, MethodImpl(Inline)]
        public void Run()
        {            
            LoadAsmDocs();

            
            var data = 0xCE_38ul;
            var command = Asm.Commands.encode(data);
            Dispatch(command);

            var steps = Buffers.Run().Slice(0, Count);
            var buffer = Buffers.Log();
            var count = asci.render(steps, buffer);
            var hexline = buffer.Slice(0,count).ToString();
            term.print(hexline);

            var seq = 0;
            var parsed = Asm.Data.AsmCommandParser.ParseAsmLine(AsmParseCases.Case01,ref seq);
            if(parsed)
                term.print($"{parsed.Value.Statement.ToString()}");
            else
                term.print("Parse failed");
        }

        void Notify(CpuEvent e)
        {
            term.print(e);
        }

        [Op, MethodImpl(Inline)]
        public void Run(ulong data)
        {
            Dispatch(Asm.Commands.encode(data));
        }

        [Op, MethodImpl(Inline)]
        public void Dispatch(in EncodedCommand src)
        {
            Execute(src.Encoding);
        }

        [Op, MethodImpl]
        public void Execute(in ReadOnlySpan<byte> src)
        {
            var buffer = Buffers.Step();
            var count = asci.codes(src, UpperCased.Case, buffer);
            var ran = buffer.Slice(0, count);
            ran.CopyTo(Buffers.Run(), Count);
            Count += count;
        }
    }
}