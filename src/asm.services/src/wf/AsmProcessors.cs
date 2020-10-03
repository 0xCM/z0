//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using Z0.Asm;


    [ApiHost]
    public readonly struct AsmProcessors
    {
        /// <summary>
        /// Creates a nonparametric process state
        /// </summary>
        [MethodImpl(Inline), Op]
        public static AsmWorkerState<T> state<T>(T s0)
            => new AsmWorkerState<T>(s0);

        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IApiAsmProcessor create(IWfShell wf)
        {
            var processor = new WfAsmProcessor(wf) as IApiAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static HostAsmProcessor hosts(IWfShell wf, ApiHostRoutines src)
            => new HostAsmProcessor(wf, src);

        [MethodImpl(Inline), Op]
        public static PartAsmProcessor parts(IWfShell wf)
            => new PartAsmProcessor(wf);

        static void OnStep(Vector128<byte> src)
        {

        }

        public static void save(ReadOnlySpan<CapturedApiResource> src, FS.FilePath dst)
        {
            const ulong Cut = 0x55005500550;
            const string Sep = SpacePipe;
            const string StartMsg = "Emitting resbytes disassembly catalog";
            const string Col0 = "Addresses";
            const string Col1 = "Accessor";
            const ushort Col0Width = 16;

            var capcount = src.Length;
            using var writer = dst.Writer();
            writer.WriteLine(text.concat(Col0.PadRight(Col0Width), Sep, Col1));

            for(var i=0u; i<capcount; i++)
            {
                ref readonly var captured = ref skip(src, i);

                var code = captured.Code;
                var host = captured.ApiHost;
                var accessor = captured.Accessor;
                var uri = OpUri.hex(host, accessor.Member.Name, code.Code.MemberId);

                var moves = AsmAnalyzer.moves(code.Routine);
                var movecount = moves.Length;
                for(var j=0u; j<movecount; j++)
                {
                    ref readonly var move = ref skip(moves,j);

                    if(move.Source < Cut)
                        writer.WriteLine(text.concat(move.Source.ToAddress().Format().PadRight(Col0Width), Sep, uri));
                }
            }
        }
    }
}