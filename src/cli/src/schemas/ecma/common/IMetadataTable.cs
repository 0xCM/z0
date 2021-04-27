//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Relations;

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