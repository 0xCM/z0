//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Services)]

namespace Z0.Parts
{
    using System;

    public sealed class Services : Part<Services>
    {

    }
}

namespace Z0
{

    partial struct Msg
    {
        public static MsgPattern<Count, DelimitedIndex<PartId>> RunningMachine => "Executing machine workflow for {0} parts: {1}";

        public static MsgPattern<Count, DelimitedIndex<PartId>> RanMachine => "Executed machine workflow for {0} parts: {1}";
    }
}