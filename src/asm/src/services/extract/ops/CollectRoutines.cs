//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    using static core;

    partial class ApiExtractor
    {
        void CollectRoutines()
        {
            CollectedDatasets = DatasetReceiver.Array();
            SortedRoutines = CollectedDatasets.SelectMany(x => x.Routines.Where(r => r != null && r.IsNonEmpty));
            SortedRoutines.Sort();
        }
    }
}