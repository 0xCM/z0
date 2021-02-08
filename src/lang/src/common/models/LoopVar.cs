//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct LoopVar
    {
        public ILoop Loop {get;}

        public Var Variable {get;}

        [MethodImpl(Inline)]
        public LoopVar(ILoop loop, Var var)
        {
            Loop = loop;
            Variable = var;
        }
    }
}