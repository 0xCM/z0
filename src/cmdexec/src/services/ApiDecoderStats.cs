//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public struct ApiDecoderStats : ITextual
    {
        public static ApiDecoderStats init()
            => new ApiDecoderStats();

        public uint MemberCount;

        public uint HostCount;

        public uint PartCount;

        public uint InstructionCount;
        public string Format()
            => text.format(WfProgress.DecodingMachine, PartCount, HostCount, MemberCount, InstructionCount);
    }
}