//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = MemoryApiKey;
    using I = IMemoryApiKey;

    partial class Kinds
    {
        public readonly struct Alloc : I { K I.Kind => K.Alloc; }

        public readonly struct Store : I { K I.Kind => K.Store; }

        public readonly struct Load : I { K I.Kind => K.Load; }

        //~ Parametric
        //~ -------------------------------------------------------------------

        public readonly struct Alloc<T> : IMemoryOpKind<Alloc,T> {}

        public readonly struct Store<T> : IMemoryOpKind<Store,T> {}

        public readonly struct Load<T> : IMemoryOpKind<Load,T> {}
    }
}