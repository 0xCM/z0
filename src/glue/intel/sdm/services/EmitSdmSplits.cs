//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static SdmModels;

    partial class IntelSdmProcessor
    {
        public Outcome EmitSdmSplits()
        {
            return DocServices.Split(SplitSpecs());
        }
    }
}