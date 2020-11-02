//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface ICsRecord
    {

    }

    [Free]
    public interface ICsRecord<R> : ICsRecord
        where R : struct, ICsRecord<R>
    {

    }
}