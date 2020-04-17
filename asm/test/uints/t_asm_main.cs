//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class t_asm_main : t_asm_explicit<t_asm_main>
    {
        protected override void OnExecute(in BufferSeq buffers)
        {                    
            
        }

        #if Dependencies

        void archive_context(in AsmBuffers buffers)
        {
            var archive = Context.Archiver();
            var selection = from c in Context.Compostion.Catalogs
                            where c.PartId != PartId.VData
                            orderby c.PartId
                            select c.PartId;
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

        #endif
    }
}