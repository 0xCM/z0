//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IReport<T>: IIndex<T>, ILocated<FS.FilePath>
        where T : struct, IRecord<T>
    {
        Index<T> Rows {get;}

        TableId TableId
            => default(T).TableId;

        T[] IIndex<T>.Storage
            => Rows.Storage;
    }
}