//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class Table
    {
        public TableId Id {get;}

        protected Table(TableId id)
        {
            Id = id;
        }

        public abstract uint RowCount {get;}
    }
}