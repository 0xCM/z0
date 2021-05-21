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
        public static int ComputeCodedTokenSize(int largeRowSize, ReadOnlySpan<int> rowCounts, TableMask tablesReferenced, bool mindelta = false)
        {
            if (mindelta)
                return 4;

            var flag = true;
            var num = (ulong)tablesReferenced;
            for (var i = 0; i<MetadataTokens.TableCount; i++)
            {
                if ((num & 1) != 0L)
                    flag = flag && skip(rowCounts, i) < largeRowSize;
                num >>= 1;
            }
            if (!flag)
                return 4;
            return 2;
        }

    }
}