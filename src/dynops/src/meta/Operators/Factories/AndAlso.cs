//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Meta.Core.Operators
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPressive;
    using static Z0.XFunc;

    public static class AndAlso<T>
    {
        static readonly Func<T, T, bool> _OP
            = lambda<T, T, bool>(Expression.AndAlso).Compile();

        public static bool Apply(T x, T y)
            => _OP(x, y);
    }
}