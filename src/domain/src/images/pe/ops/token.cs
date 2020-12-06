//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;
    using static z;

    partial class PeTableReader
    {
        public static CliTableIndex? index(in ReaderState state, Handle handle)
        {
            if(!handle.IsNil)
            {
                var table = index(handle);
                var token = state.Reader.GetToken(handle);
                if (table != null)
                    return new CliTableIndex(token, table.Value);
            }

            return null;
        }
    }
}