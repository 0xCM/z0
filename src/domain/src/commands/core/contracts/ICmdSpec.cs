//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdSpec
    {
        CmdId Id {get;}
    }

    [Free]
    public interface ICmdSpec<T> : ICmdSpec
        where T : struct
    {
        CmdId ICmdSpec.Id =>
            CmdId.from<EmitAsmOpCodesCmd>();
    }

    [Free]
    public interface ICmdSpec<K,T> : ICmdSpec<CmdOptions<K,T>>
        where K : unmanaged

    {

    }

    [Free]
    public interface ICmdSpec<H,K,T> : ICmdSpec<K,T>
        where K : unmanaged
        where H : struct, ICmdSpec<H,K,T>
    {

    }
}