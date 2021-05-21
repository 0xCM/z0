//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static core;

    partial class SRM
    {
        [MethodImpl(Inline), Op]
        public static int GetReferenceSize(ReadOnlySpan<int> rowCounts, TableIndex index, bool mindelta = false)
        {
            if ((long)skip(rowCounts, (uint)index) >= 65536L || mindelta)
                return 4;
            return 2;
        }
    }
}