//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    
    using C = OpCodes;
    using E = EncodedOpCode;

    public class OpCodeEncodings
    {
        public static E JaRel8 => C.JaRel8;

        public static E JaRel16 => C.JaRel16;

        public static E JaRel32 => C.JaRel32;

        public static E JaeRel8 => C.JaeRel8;

        public static E JaeRel16 => C.JaeRel16;

        public static E JaeRel32 => C.JaeRel32;
    }
}