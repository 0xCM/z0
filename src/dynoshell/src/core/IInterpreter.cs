//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IInterpreter : IWfService
    {
        Outcome Start();

        void Post(string command);
    }

    [Free]
    public interface IInterpreter<H> : IInterpreter, IWfService<H>
        where H : Interpreter<H>, new()
    {

    }
}