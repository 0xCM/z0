//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IWfDataProcessor
    {
        void Connect() {}
    }

    [Free]
    public interface IWfDataProcessor<S> : IWfDataProcessor
    {
        void Process(S src);
    }
}