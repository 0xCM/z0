//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class FieldExtensions
    {
        internal static string FormatEntry<F>(this F entry)
            where F : IFieldIndexEntry
                => $"{entry.FieldValue.GetType().Name}[{entry.Index}] = {entry.FieldName}";
    }

}