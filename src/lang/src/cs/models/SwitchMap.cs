//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang.Cs
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct SwitchMap<C,T>
    {
        public Identifier Name;

        public Tests<C,T> Cases;

        [MethodImpl(Inline)]
        public SwitchMap(Identifier name, Tests<C,T> cases)
        {
            Name = name;
            Cases = cases;
        }
    }
}