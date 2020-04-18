//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Meta.Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;

    /// <summary>
    /// Collects standard method classifications
    /// </summary>
    public class StandardMethods
    {
        public static IEnumerable<StandardMethod> All 
            => seq(ThenBy, ThenByDescending, OrderBy, OrderByDescending, Select, Where); 
        
        public static StandardMethod ThenBy 
            => new OrderSpecificationMethod(nameof(ThenBy), SortDirection.Ascending, false);

        public static StandardMethod ThenByDescending 
            => new OrderSpecificationMethod(nameof(ThenByDescending), SortDirection.Descending, false);

        public static StandardMethod OrderBy 
            => new OrderSpecificationMethod(nameof(ThenBy), SortDirection.Ascending, true);

        public static StandardMethod OrderByDescending 
            => new OrderSpecificationMethod(nameof(ThenByDescending), SortDirection.Descending, true);

        public static StandardMethod Select
            => new SelectMethod();

        public static StandardMethod Where 
            => new WhereMethod();
    }
}