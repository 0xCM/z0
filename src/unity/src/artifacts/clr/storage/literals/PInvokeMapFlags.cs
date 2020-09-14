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
        public enum PInvokeMapFlags : ushort
        {
            NoMangle = 0x0001,

            DisabledBestFit = 0x0020,

            EnabledBestFit = 0x0010,

            UseAssemblyBestFit = 0x0000,

            BestFitMask = 0x0030,

            CharSetNotSpec = 0x0000,

            CharSetAnsi = 0x0002,

            CharSetUnicode = 0x0004,

            CharSetAuto = 0x0006,

            CharSetMask = 0x0006,

            EnabledThrowOnUnmappableChar = 0x1000,

            DisabledThrowOnUnmappableChar = 0x2000,

            UseAssemblyThrowOnUnmappableChar = 0x0000,

            ThrowOnUnmappableCharMask = 0x3000,

            SupportsLastError = 0x0040,

            WinAPICallingConvention = 0x0100,

            CDeclCallingConvention = 0x0200,

            StdCallCallingConvention = 0x0300,

            ThisCallCallingConvention = 0x0400,

            FastCallCallingConvention = 0x0500,

            CallingConventionMask = 0x0700,
        }

    }
}