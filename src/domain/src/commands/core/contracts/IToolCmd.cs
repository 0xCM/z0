//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToolCmd
    {
        string[] Args {get;}

        KeyedValues<string,string> Options {get;}
    }


}