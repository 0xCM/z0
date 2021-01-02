//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Instruction<C,K,T>
    {
        public C Class {get;}

        public K Kind {get;}

        public T Content {get;}
    }
}