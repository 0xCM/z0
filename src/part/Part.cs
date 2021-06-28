//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Part)]

namespace Z0.Parts
{
    public sealed partial class Part : Part<Part>
    {

    }
}

namespace Z0
{
    using System;

    using static Root;

    [ApiHost]
    public static partial class XTend
    {
        const NumericKind Closure = UnsignedInts;
    }

    [ApiComplete]
    partial struct Msg
    {


        public static MsgPattern<Type,Type> ContractMismatch => "The source type {0} does not reify {1}";
    }
}