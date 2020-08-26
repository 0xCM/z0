//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Iced.Intel;

    using static Konst;

    using Iced = Iced.Intel;

    partial class IceExtractors
    {
       public static AsmFlowInfo FxFlow(Iced.Code src)
            => new AsmFlowInfo
            {
                Code = Deicer.Thaw(src),
                ConditionCode = Deicer.Thaw(src.GetConditionCode()),
                IsStackInstruction = src.IsStackInstruction(),
                FlowControl = Deicer.Thaw(src.FlowControl()),
                IsJccShortOrNear = src.IsJccShortOrNear(),
                IsJccNear = src.IsJccNear(),
                IsJccShort = src.IsJccShort(),
                IsJmpShort = src.IsJmpShort(),
                IsJmpNear = src.IsJmpNear(),
                IsJmpShortOrNear = src.IsJmpShortOrNear(),
                IsJmpFar = src.IsJmpFar(),
                IsCallNear = src.IsCallNear(),
                IsCallFar = src.IsCallFar(),
                IsJmpNearIndirect = src.IsJmpNearIndirect(),
                IsJmpFarIndirect = src.IsJmpFarIndirect(),
                IsCallNearIndirect = src.IsCallNearIndirect(),
                IsCallFarIndirect = src.IsCallFarIndirect()
            };
    }
}