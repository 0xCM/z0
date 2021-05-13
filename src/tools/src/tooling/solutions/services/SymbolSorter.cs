//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/source-indexer
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial struct CodeSolutions
    {
        public class SymbolSorter
        {
            public static void SortSymbols(List<DeclaredSymbolInfo> declaredSymbols)
            {
                declaredSymbols.Sort(Sorter);
            }

            private static int Sorter(DeclaredSymbolInfo left, DeclaredSymbolInfo right)
            {
                if (left == right)
                {
                    return 0;
                }

                if (left == null || right == null)
                {
                    return 1;
                }

                int comparison = StringComparer.OrdinalIgnoreCase.Compare(left.Name, right.Name);
                if (comparison != 0)
                {
                    return comparison;
                }

                comparison = left.KindRank.CompareTo(right.KindRank);
                if (comparison != 0)
                {
                    return comparison;
                }

                comparison = StringComparer.Ordinal.Compare(left.Name, right.Name);
                if (comparison != 0)
                {
                    return comparison;
                }

                comparison = left.AssemblyNumber.CompareTo(right.AssemblyNumber);
                return comparison;
            }
        }
    }
}