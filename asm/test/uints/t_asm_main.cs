//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Root;
    using static Nats;

    class t_asm_main : t_asm_explicit<t_asm_main>
    {
        protected override void OnExecute(in AsmBuffers buffers)
        {                    
            buffer_client(Context);
            // capture_shifter(buffers);
            // capture_shuffler(buffers);
            // capture_constants(buffers);
            //binary_imm(buffers);
            //bitlogic_match(buffers);
            // archive_selected(buffers);        
            // archive_context(buffers);            
        }

        void archive_selected(in AsmBuffers buffers)
        {
            var archive = Context.Archiver();
            //archive.Archive(AssemblyId.Root);
        }

        void archive_context(in AsmBuffers buffers)
        {
            var archive = Context.Archiver();
            var selection = from c in Context.Compostion.Catalogs
                            where c.AssemblyId != AssemblyId.Data
                            orderby c.AssemblyId
                            select c.AssemblyId;
            foreach(var id in selection)
                archive.Archive(id);    
        }

        static void buffer_client(IAsmContext context)
        {
            var state = new List<ExtractionState>();
            var f = typeof(BitMask).Method(nameof(BitMask.alteven))
                                 .MapRequired(m => m.GetGenericMethodDefinition()
                                 .MakeGenericMethod(typeof(byte)));

            var decoder = context.AsmFunctionDecoder();

            using var hexout = HexWriter(context);            
            using var codeout = CodeWriter(context);
            using var asmout = FunctionWriter(context);            
                        
            void OnExecute(in AsmBuffers buffers)
            {            
                var capture = buffers.Capture;
                var captured = capture.Capture(buffers.Exchange, f);
                codeout.WriteCode(captured.Code);
                hexout.WriteHexLine(captured);
                asmout.Write(decoder.DecodeFunction(captured));
                Claim.eq(captured.RawBits.Length, state.Count);
            }

            void OnCaptureEvent(in AsmCaptureEvent data)
            {
                if(data.EventKind != CaptureEventKind.Complete)
                {
                    //print($"{data.CaptureState}", AppMsgKind.HiliteBL);
                    state.Add(data.CaptureState);
                }
            }

            var composition = context.BufferedClient(OnExecute);
            using var buffers = context.Buffers(OnCaptureEvent);
            composition.Execute(buffers);

            var stateBytes = state.Select(s => s.Payload).ToArray();
        }


   }
}