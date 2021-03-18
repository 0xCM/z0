//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = ApiMemoryClass;
    using I = IMemoryApiKey;

    partial struct ApiClasses
    {
        public readonly struct Alloc : I { K I.Kind => K.Alloc; }

        public readonly struct Store : I { K I.Kind => K.Store; }

        public readonly struct Load : I { K I.Kind => K.Load; }

        //~ Parametric
        //~ -------------------------------------------------------------------

    }
}