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
        public void capture_workflow()
        {                    
            var extracts = list<AsmHostExtract>();            
            var paths = Context.EmissionPaths();                    
            var workflow = Context.HostCaptureFlow();
            foreach(var extract in workflow.Execute())
            {
                Claim.exists(paths.ParsedCapturePath(extract.Host));
                extracts.Add(extract);                            
            }   

            var callsfar = extracts.FarCalls().Distinct().ToArray();
            var bases = extracts.BaseAddresses().ToArray();
            var known = callsfar.Intersect(bases).ToArray();
            var unknown = bases.Except(known).ToArray();
            var fcs = FarCallSummary.Define(
                targets: callsfar,
                hosted: bases,
                known: known,
                unknown: unknown);  

            Trace(fcs.Format());
        
        }

        // HashSet<MemoryAddress> Targets {get;}
        //     = new HashSet<MemoryAddress>();

        // void OnWorkflowComplete(IAsmHostCaptureFlow flow, in AsmHostExtract src)
        // {
        //     Trace($"Completed {flow.Name} for {src.Host}");

        //     var callers = new List<CallerTarget>();
        //     foreach(var f in src.Decoded)
        //     {
        //         foreach(var i in f.Instructions)   
        //         {                    
        //             if(i.FlowControl == FlowControl.Call)
        //                 callers.Add(CallerTarget.Define(f.Uri, i.MemoryAddress64));
        //         }                        
        //     }
            
        //     var distinct = callers.Select(c => c.Dst).Distinct().ToList();
        //     Targets.Include(distinct);

        //     Trace($"Collected {callers.Count} total far calls for {src.Host} that included unique {distinct.Count} targets out of {Targets.Count} distinct targets for the session");
        // }

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
