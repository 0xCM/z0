//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial struct Images
    {

        [Record]
        public struct NameIndexStreamHeader : IRecord<NameIndexStreamHeader>
        {
            public Cell32 Version;

            public Cell32 Signature;

            public Cell32 Age;

            public Cell128 Guid;

            public Cell32 CountStringBytes;
        }

    }
}