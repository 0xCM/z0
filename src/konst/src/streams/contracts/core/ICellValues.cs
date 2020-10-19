//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICellValues<T> : IValueSource<T>
        where T : struct, IDataCell
    {

    }

    [Free]
    public interface ICellSource : IValueSource
    {

    }

    [Free]
    public interface IDomainCells<T> : IDomainValues<T>
        where T : struct, IDataCell
    {

    }

}