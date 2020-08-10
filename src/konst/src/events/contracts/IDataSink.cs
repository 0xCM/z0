//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IDataSink : ISink
    {
       void Deposit(IDataEvent e);

       void Deposit<S>(in S e)        
            where S : struct, IDataEvent
                => Deposit((IDataEvent)e);
    }        
}