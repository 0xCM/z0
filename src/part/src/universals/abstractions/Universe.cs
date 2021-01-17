//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct Universal : IUniversal
    {

    }


    public abstract class Universe<U> : IUniversal<U>
        where U : Universe<U>, new()
    {
        public static U create(IUniversal context)
        {
            var u  = new U();
            u.Context = context;
            u.Init();
            return u;
        }

        protected IUniversal Context {get; private set;}

        protected virtual void Init() { }
    }

    public abstract class Universe<U,S> : IUniversal<U>
        where U : Universe<U,S>, new()
        where S : struct
    {
        [FixedAddressValueType]
        protected static S DataStore = new S();

        protected IUniversal Context {get; private set;}

        protected virtual void Init() { }
    }

}