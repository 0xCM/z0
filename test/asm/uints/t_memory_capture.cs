//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class t_memory_capture : t_asm<t_memory_capture>
    {
        public override bool Enabled => false;

        public void call32_intr_pattern()
        {
            var patterns = EncodingPatterns.Default;
            if(patterns.TryPartialMatch(EncodingPatternKind.CALL32_INTR, AsChar_Span8u_Input, out var selected))
                Claim.ClaimEq(AsChar_Span8u_Output, selected);
            else
                Claim.Fail();
        }

        public void check_decoder()
        {
            DecodeHostBits(Context.ApiGlobal.ApiHosts.Map(h => h.Uri));
        }

        public static ReadOnlySpan<byte> AsChar_Span8u_Input
            => new byte[]{
                0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0x02,
                0x8b,0x52,0x08,0xd1,0xea,0x48,0x89,0x01,
                0x89,0x51,0x08,0x48,0x8b,0xc1,0x48,0x83,
                0xc4,0x28,0xc3,0xe8,0xd0,0xa5,0x4f,0x5f,
                0xcc,0x00,0x00,0x00,0x19,0x04,0x01,0x00,
                0x04,0x42,0x00,0x00,0x40
                };

        public static ReadOnlySpan<byte> AsChar_Span8u_Output
            => new byte[]{
                0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0x02,
                0x8b,0x52,0x08,0xd1,0xea,0x48,0x89,0x01,
                0x89,0x51,0x08,0x48,0x8b,0xc1,0x48,0x83,
                0xc4,0x28,0xc3,0xe8,0xd0,0xa5,0x4f,0x5f,
                0xcc,
                };
    }
}