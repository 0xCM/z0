//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Meta.Core
{
    using System;
    using System.Linq;

    using Modules;

    /// <summary>
    /// Defines the canonical see <see cref="IndexImmutable{X}"/> monad for LINQ integration
    /// </summary>
    public static class IndexM
    {

        public static IndexImmutable<Y> Select<X, Y>(this IndexImmutable<X> index, Func<X, Y> selector)
             => IndexImmutable.make(from x in index.Stream() select selector(x));

        public static IndexImmutable<Z> SelectMany<X, Y, Z>(this IndexImmutable<X> index, Func<X, IndexImmutable<Y>> lift, Func<X, Y, Z> project)
            => IndexImmutable.make(from x in index.Stream()
                         from y in lift(x).Stream()
                         select project(x, y));

        public static IndexImmutable<X> Where<X>(this IndexImmutable<X> index, Func<X, bool> predicate)
            => IndexImmutable.make(from x in index.Stream() where predicate(x) select x);
    }
}