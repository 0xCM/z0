//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IOp
    {
        Label OpName {get;}        
    }

    public interface IOp<S> : IOp
    {

    }

    public interface IOp<S,T> : IOp
    {

    }
}