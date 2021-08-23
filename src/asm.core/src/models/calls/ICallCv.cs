//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICallCv
    {
        CcvKind Kind {get;}
    }

    [Free]
    public interface ICallCv<T> : ICallCv
        where T : unmanaged, ICallCv<T>
    {

    }
}