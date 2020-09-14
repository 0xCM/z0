//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    partial struct ClrStorage
    {
        public enum SigHeaderCode : byte
        {
            DefaultCall = 0x00,

            CCall = 0x01,

            StdCall = 0x02,

            ThisCall = 0x03,

            FastCall = 0x04,

            VarArgCall = 0x05,

            Field = 0x06,

            LocalVar = 0x07,

            Property = 0x08,

            GenericInstance = 0x0A,

            Max = 0x0C,

            CallingConventionMask = 0x0F,

            HasThis = 0x20,

            ExplicitThis = 0x40,

            Generic = 0x10,

            SignatureHeaderMask = 0x7F,
        }
    }
}