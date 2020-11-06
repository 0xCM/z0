//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataSink : ISink
    {
       void Deposit(IDataEvent e);

       void Deposit<S>(in S e)
            where S : struct, IDataEvent
                => Deposit((IDataEvent)e);
    }
}