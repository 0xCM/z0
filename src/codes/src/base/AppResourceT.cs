//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AppResource<T> : IAppResource<T>
    {
        [MethodImpl(Inline)]
        public AppResource(string name, T data)
        {
            this.Name = name;
            this.Data = data;
        }

        public string Name {get;}

        public T Data {get;}        
    }
}