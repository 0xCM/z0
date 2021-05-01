//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICalcResult
    {
        ApiKey Api {get;}
    }

    [Free]
    public interface ICalcResult<H> : ICalcResult, IRecord<H>
        where H : unmanaged, ICalcResult<H>
    {
    }

    [Free]
    public interface ICalcResult<H,R> : ICalcResult<H>
        where H : unmanaged, ICalcResult<H,R>
        where R : unmanaged
    {
        R Value {get;}
    }
}