//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

   /// <summary>
    /// Characterizes an unlimited value emitter that produces one value at a time
    /// </summary>
    /// <typeparam name="T">The production value type</typeparam>
    [Free]
    public interface IValueSource<T> : ISource<T>
        where T : struct
    {

    }

}