//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public class t_memory_capture : t_asm<t_memory_capture>
    {    
        bool MemcapCheck(IMemoryCapture memcap, OperationBits src)
        {
            var captured = memcap.Capture(src.Address);
            if(!captured)
                return false;

            var data = captured.Value.Parsed.Parsed;
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
                Claim.Fail();
        }

        public IEnumerable<OperationBits> ReadHostBits(ApiHostUri host)
        {            
            var paths = Paths.ForApp(PartId.Control);
            var root = paths.AppCapturePath;
            var reader = Archives.Services.Operational(root);
            return reader.ReadHex(host);
        }

        void check_decoder(IEnumerable<ApiHostUri> hosts)
        {
            var decoder = AsmCheck.Decoder;

            var totalCount = 0ul;
            var hostCount = 0ul;

            void Decoded(Instruction i)
            {
                hostCount++;
                totalCount++;                
            }

            foreach(var host in hosts)
            {
                hostCount = 0;
                var bits = ReadHostBits(host).ToArray();
                trace($"Loaded host bits", $"{bits.Length} | {host.Format()}");
                foreach(var f in bits) 
                {            
                    decoder.DecodeInstructions(f.Encoded, Decoded);
                }
                
                trace($"Decoded host instructions", $"{hostCount} | {totalCount} | {host.Format()}");
            }

        }

        public void check_decoder()
        {
            check_decoder(Context.ApiSet.Hosts.Select(h => h.UriPath));

                       
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