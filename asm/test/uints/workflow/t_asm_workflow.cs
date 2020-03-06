//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Root;

    public class t_asm_capture : t_asm<t_asm_capture>
    {

        public void host_workflow_2()
        {
            var extractor = Context.HostExtractor();
            foreach(var catalog in Context.Compostion.Catalogs)   
            {
                foreach(var host in catalog.ApiHosts)
                {
                    var extraction = extractor.Extract(host);
                    
                }
            }
        }
        public void host_workflow()
        {                    
            var extracts = list<CapturedHost>();            
            var paths = Context.EmissionPaths();                    
            var workflow = Context.HostCaptureWorkflow();
            var memcap = Context.MemoryCapture();
            var memfail = list<OpUri>();
            foreach(var extract in workflow.Execute())
            {
                Claim.exists(paths.ParsedCapturePath(extract.Host));
                extracts.Add(extract); 
                var count = extract.Parsed.RecordCount;
                for(var i=0; i<count; i++)
                {
                    var parsed = extract.Parsed[i];
                    var code = AsmCode.Define(parsed.Uri.OpId, parsed.Data);
                    if(!MemcapCheck(memcap, code))
                        memfail.Add(parsed.Uri);

                }
            }   

            foreach(var fail in memfail)
                Trace(AppMsg.Warn($"Memory capture failed for {fail}"));
        }

        bool MemcapCheck(IMemoryCapture memcap, AsmCode src)
        {
            var section = new string('-',120);
            var captured = memcap.Capture(src.BaseAddress);
            if(!captured)
                return false;

            var data = captured.Value.ExtractedData.Parsed;
            if(data.Length != src.Length)
                return false;
            return true;
        }

        public void call32_intr_pattern()
        {
            var patterns = EncodingPatterns.Default;
            if(patterns.TryPartialMatch(EncodingPatternKind.CALL32_INTR, AsChar_Span8u_Input, out var selected))
                Claim.eq(AsChar_Span8u_Output,selected);
            else
                Claim.fail();
        }

        static ReadOnlySpan<byte> AsChar_Span8u_Input 
            => new byte[]{
                0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0x02,
                0x8b,0x52,0x08,0xd1,0xea,0x48,0x89,0x01,
                0x89,0x51,0x08,0x48,0x8b,0xc1,0x48,0x83,
                0xc4,0x28,0xc3,0xe8,0xd0,0xa5,0x4f,0x5f,
                0xcc,0x00,0x00,0x00,0x19,0x04,0x01,0x00,
                0x04,0x42,0x00,0x00,0x40
                };

        static ReadOnlySpan<byte> AsChar_Span8u_Output
            => new byte[]{
                0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0x02,
                0x8b,0x52,0x08,0xd1,0xea,0x48,0x89,0x01,
                0x89,0x51,0x08,0x48,0x8b,0xc1,0x48,0x83,
                0xc4,0x28,0xc3,0xe8,0xd0,0xa5,0x4f,0x5f,
                0xcc,
                };
    }
}
