//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a reified application event
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    [Free]
    public interface IAppEvent<F> : IAppEvent, INullary<F>, ICorrelated<F>, IChronic<F>
        where F : struct, IAppEvent<F>
    {
        F INullary<F>.Zero
            => default;
    }

    [Free]
    public interface IAppEvent<F,T> : IAppEvent<F>
        where F : struct, IAppEvent<F,T>
    {
        EventPayload<T> Content => default;
    }
}