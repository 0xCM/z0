//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IWfDataEvent : IWfEvent, IDataEvent
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IWfDataEvent<T> : IWfDataEvent
        where T : struct, ITable<T>
    {

        T Data {get;}
    }


    [SuppressUnmanagedCodeSecurity]
    public interface IWfDataEvent<H,T> : IWfDataEvent<T>, IDataEvent<H>
        where H : struct, IWfDataEvent<H,T>
        where T : struct, ITable<T>        
    {
        
    }
}