//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Flows
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IMask : ITextual
    {
        MaskKind Kind {get;}

        ulong Value {get;}
    }

    [Free]
    public interface IMask<T> : IMask
        where T : unmanaged, IMask<T>
    {
    }
}