//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;

    public abstract class CodeModel<T>
        where T : CodeModel<T>, new()
    {
        public string Name {get;set;}
    }
}