//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdVar<T>
    {
        CmdVarSymbol Symbol {get;}

        T Value {get;}
    }

    [Free]
    public interface ICmdVar : ICmdVar<string>
    {


    }
}