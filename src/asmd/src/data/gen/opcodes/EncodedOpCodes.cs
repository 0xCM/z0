//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using static HexKind;
    using static OpCodeTokenKind;

    using H = OpCodes.Descriptions;
    using X = OpCodes.Expressions;
    using I = OpCodes.Instructions;
    
    public class EncodedOpCodes
    {            
        const byte TokenWidth = quintet.Max8u; 

        [OpCode(X.JaRel8, I.JaeRel8, H.JaRel8)]
        public const ulong JaRel8 = (ulong)x77 | (ulong)cb << TokenWidth;

        [OpCode(X.JaRel16, I.JaRel16, H.JaRel16)]
        public const ulong JaRel16 = (ulong)x87 | (ulong)cw << TokenWidth;

        [OpCode(X.JaRel32,I.JaRel32, H.JaRel32)]
        public const ulong JaRel32 = (ulong)x87 | (ulong)cd << TokenWidth;

        [OpCode(X.JaeRel8,I.JaeRel8, H.JaeRel8)]
        public const ulong JaeRel8 = (ulong)x73 | (ulong)cb << TokenWidth;

        [OpCode(X.JaeRel16, I.JaeRel16,  H.JaeRel16)]
        public const ulong JaeRel16 = (ulong)x83 | (ulong)cw << TokenWidth;

        [OpCode(X.JaeRel32, I.JaeRel32,  H.JaeRel32)]
        public const ulong JaeRel32 = (ulong)x83 | (ulong)cd << TokenWidth;
    }
}