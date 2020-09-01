//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISingletonSource<T> : ISource<T>
    {
        T Value {get;}

        T ISource<T>.Next() 
            => Value;
    }
}