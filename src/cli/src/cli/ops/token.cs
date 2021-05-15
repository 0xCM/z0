//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Root;

    partial struct Cli
    {
        [MethodImpl(Inline), Op]
        public static CliToken token(Handle src)
        {
            var _data = data(src);
            return new CliToken(_data.Table, _data.RowId);
        }
    }
}