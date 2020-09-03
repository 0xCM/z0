//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using K = SystemOpKind;
    using I = ISystemOpKind;

    partial class Kinds
    {
        public readonly struct Init : I { K I.Kind => K.Init; }
        
        public readonly struct Kind : I { K I.Kind => K.Kind; }


        //~ Parametric
        //~ -------------------------------------------------------------------
        
        public readonly struct Init<T> : ISystemOpKind<Init,T> {}

        public readonly struct Kind<T> : ISystemOpKind<Kind,T> {}        
    }
}