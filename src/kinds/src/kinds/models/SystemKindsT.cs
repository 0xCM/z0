//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    partial class Kinds
    {
        public readonly struct Alloc<T> : ISystemOpKind<Alloc,T> {}

        public readonly struct Store<T> : ISystemOpKind<Store,T> {}

        public readonly struct Load<T> : ISystemOpKind<Load,T> {}

        public readonly struct Init<T> : ISystemOpKind<Init,T> {}

        public readonly struct Kind<T> : ISystemOpKind<Kind,T> {}
    }
}