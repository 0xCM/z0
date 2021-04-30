//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Images
    {
        public interface IMetadataTable
        {
            byte TableId {get;}

            string TableName {get;}
        }

        public interface IMetadataTable<T> : IMetadataTable
            where T : struct, IMetadataTable<T>
        {

        }
    }
}