//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial struct ImageRecords
    {
        public struct StreamHeader : IRecord<StreamHeader>
        {
            public Address32 Offset;

            public uint StreamSize;

            public string Name;
        }
    }
}