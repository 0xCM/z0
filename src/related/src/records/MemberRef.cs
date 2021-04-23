//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct MemberRef : IRecord<MemberRef>
        {
            public const string TableId = "image.memberrefs";

            public ClrToken Token;

            public MemberRefKind RefKind;

            public ClrToken Parent;

            public Name Name;

            public CliSig Sig;
        }
    }
}