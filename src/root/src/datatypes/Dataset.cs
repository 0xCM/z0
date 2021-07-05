//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Dataset : IDataset
    {
        public Name Identity {get;}

        [MethodImpl(Inline)]
        public Dataset(string id)
        {
            Identity = id;
        }
    }

}