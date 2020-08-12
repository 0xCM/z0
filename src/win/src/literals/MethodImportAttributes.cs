//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [Flags]
    public enum MethodImportAttributes : short
    {
        None = (short)0,

        ExactSpelling = (short)1,

        CharSetAnsi = (short)2,

        CharSetUnicode = (short)4,

        CharSetAuto = (short)6,

        CharSetMask = (short)6,

        BestFitMappingEnable = (short)16,

        BestFitMappingDisable = (short)32,

        BestFitMappingMask = (short)48,

        SetLastError = (short)64,

        CallingConventionWinApi = (short)256,

        CallingConventionCDecl = (short)512,

        CallingConventionStdCall = (short)768,

        CallingConventionThisCall = (short)1024,

        CallingConventionFastCall = (short)1280,

        CallingConventionMask = (short)1792,

        ThrowOnUnmappableCharEnable = (short)4096,

        ThrowOnUnmappableCharDisable = (short)8192,

        ThrowOnUnmappableCharMask = (short)12288,
    }
}