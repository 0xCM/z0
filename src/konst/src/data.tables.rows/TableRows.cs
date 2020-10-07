//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.TableRows)]
    public readonly partial struct TableRows
    {
        [MethodImpl(Inline)]
        public static RowAdapter<T> adapter<T>(in TableFieldIndex fields)
            where T : struct
                => new RowAdapter<T>(fields);

        public static RowAdapter<T> adapter<T>()
            where T : struct
                => adapter<T>(TableFields.index<T>());
    }
}