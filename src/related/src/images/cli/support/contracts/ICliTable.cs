//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICliRecord
    {
        byte TableId {get;}

        string TableName {get;}
    }

    public interface ICliRecord<T> : ICliRecord, IRecord<T>
        where T : struct, ICliRecord<T>
    {

    }
}