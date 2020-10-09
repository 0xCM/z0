//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct DbTableArchive
    {
        public IDbArchive Database {get;}

        public string TableId {get;}

        [MethodImpl(Inline)]
        public DbTableArchive(IDbArchive db, string table)
        {
            Database = db;
            TableId = table;
        }
    }
}