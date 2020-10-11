//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;
    using static RP;

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