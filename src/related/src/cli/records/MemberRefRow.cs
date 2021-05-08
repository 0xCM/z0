//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.MemberRef), StructLayout(LayoutKind.Sequential)]
        public struct MemberRefRow : IRecord<MemberRefRow>
        {
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