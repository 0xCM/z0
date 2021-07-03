//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class IntelSdmProcessor
    {
        public Outcome EmitSplitSdm()
        {
            return DocServices.Split(SplitSpecs());
        }
    }
}