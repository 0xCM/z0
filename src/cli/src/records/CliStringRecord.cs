//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
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
    }
}