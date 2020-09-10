//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class SettingValues<F> : ISettings<F>
        where F : SettingValues<F>, new()
    {
        public static F From(ISettings src)
            => SettingValues.From<F>(src);
    }
}