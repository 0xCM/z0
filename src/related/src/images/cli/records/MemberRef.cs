//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct MemberRefRow : IRecord<MemberRefRow>
        {
            public const string TableId = "image.memberrefs";

            public CliToken Token;

            public MemberRefKind RefKind;

            public CliToken Parent;

            public Name Name;

            public CliSig Sig;
        }

        public enum MemberRefKind : byte
        {
            Method,

            Field = 1,
        }
    }
}