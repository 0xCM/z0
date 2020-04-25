//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using K = SystemOpKind;
    using I = ISystemOpKind;

    partial class Kinds
    {
        public readonly struct Alloc : I { K I.Kind => K.Alloc; }

        public readonly struct Store : I { K I.Kind => K.Store; }

        public readonly struct Load : I { K I.Kind => K.Load; }

        public readonly struct Init : I { K I.Kind => K.Init; }
        
        public readonly struct Kind : I { K I.Kind => K.Kind; }

    }
}