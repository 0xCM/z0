//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AppResource<T> : IAppResource<T>
    {
        public string Name {get;}

        public T Content {get;}        
        
        [MethodImpl(Inline)]
        public AppResource(string name, T data)
        {
            Name = name;
            Content = data;
        }
    }
}