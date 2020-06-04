//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using static HexKind;
    using static OpCodeToken;

    using T = OpCodeToken;
    using H = OpCodes.Descriptions;
    using X = OpCodes.Expressions;
    using I = OpCodes.Instructions;
    
    public partial class OpCodes
    {            
        const byte TW = (byte)T.Width;            

        [OpCode(X.JaRel8, I.JaeRel8, H.JaRel8)]
        public const ulong JaRel8 = (ulong)x77 | (ulong)cb << TW;

        [OpCode(X.JaRel16, I.JaRel16, H.JaRel16)]
        public const ulong JaRel16 = (ulong)x87 | (ulong)cw << TW;

        [OpCode(X.JaRel32,I.JaRel32, H.JaRel32)]
        public const ulong JaRel32 = (ulong)x87 | (ulong)cd << TW;

        [OpCode(X.JaeRel8,I.JaeRel8, H.JaeRel8)]
        public const ulong JaeRel8 = (ulong)x73 | (ulong)cb << TW;

        [OpCode(X.JaeRel16, I.JaeRel16,  H.JaeRel16)]
        public const ulong JaeRel16 = (ulong)x83 | (ulong)cw << TW;

        [OpCode(X.JaeRel32, I.JaeRel32,  H.JaeRel32)]
        public const ulong JaeRel32 = (ulong)x83 | (ulong)cd << TW;
    }
}