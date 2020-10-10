//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static RP;


    public readonly struct CliStringRecords
    {
        public const string DataType = "strings";

        public const string UserKind = "user";

        public const string SystemKind = "system";

        public const string UserTargetFolder = DataType + ExtSep + UserKind;

        public const string SystemTargetFolder = DataType + ExtSep + SystemKind;

        public const string DataTypeExt = DataType + ExtSep + DataExt;

        public const string UserKindExt = UserKind + ExtSep + DataTypeExt;

        public const string SystemKindExt = SystemKind + ExtSep + DataTypeExt;
    }


    public struct CliStringRecord
    {
        public enum Kind
        {
            System = 0,

            User = 1,
        }

        public enum Source : byte
        {
            System = 1,

            User = 2,
        }


        public enum Fields : ushort
        {
            Sequence,

            Source,

            HeapSize,

            Length,

            Offset,

            Value,
        }

        public enum RenderWidths : ushort
        {
            Sequence = 12,

            Source = 12,

            HeapSize = 12,

            Length = 12,

            Offset = 12,

            Value = 12,
        }

    }

}