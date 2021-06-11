//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Threading.Tasks;

    using static Part;

    public static class TimeSeries
    {
        [MethodImpl(Inline)]
        public static SeriesEvolution<T> evolution<T>(in ulong[] seed, in Interval<T> domain,
            in SeriesTerm<T> first, in SeriesTerm<T> final, in Duration time)
                where T : unmanaged
                    => new SeriesEvolution<T>(seed, domain, first, final, time);

        public static SeriesTerm<T> term<T>(long index, T value)
            where T : unmanaged
                => new SeriesTerm<T>(index, value);

        static long LastSeriesId;

        static readonly ConcurrentDictionary<long, IDomainSource> States
            = new ConcurrentDictionary<long, IDomainSource>();

        public static SeriesTerm<T> next<T>(TimeSeries<T> series)
            where T : unmanaged
        {
            if(States.TryGetValue(series.Id, out IDomainSource source))
            {
                var _term = term(series.Observed.Index + 1, source.Next<T>(series.Domain));
                series.Witnessed(_term);
                return _term;
            }
            else
                return series.Observed;
        }

        internal static IEnumerable<SeriesTerm<T>> evolve<T>(TimeSeries<T> series)
            where T : unmanaged
        {
            if(States.TryGetValue(series.Id, out IDomainSource source))
            {
                while(true)
                {
                    var _term = term(series.Observed.Index + 1, source.Next<T>(series.Domain));
                    series.Witnessed(_term);
                    yield return _term;
                }
            }
        }

        public static TimeSeries<T> define<T>(Interval<T> domain, ulong[] seed)
            where T : unmanaged
        {
            var id = root.atomic(ref LastSeriesId);
            var rng = Rng.xorShift1024(seed);
            if(!States.TryAdd(id,rng))
                throw new Exception($"Key {id} already exists");
            return new TimeSeries<T>(id, domain, term(0, memory.zero<T>()));
        }

        public static void evolve<T>(Interval<T> domain, ulong[] seed, int count, Action<TimeSeries<T>,Duration> complete)
            where T : unmanaged
        {
            var sw = Time.stopwatch();
            var series = define(domain, seed);
            var terms = series.Terms().ToSpan(count);
            var elapsed = Duration.init(sw.ElapsedTicks);
            root.invariant(terms.Length == count,() =>"");
            root.invariant(series.Observed.Observed.Equals(terms[count - 1].Observed), () => "");
            complete(series,elapsed);
        }

        public static Task<SeriesEvolution<T>> evolve<T>(ulong[] seed, Interval<T> domain, int steps)
            where T : unmanaged
            => Task.Factory.StartNew(() => run(seed, domain, steps));

        public static async Task evolve<T>(Interval<T> domain, Action<SeriesEvolution<T>> receiver, int count = Pow2.T06, int steps = (int)Pow2.T19)
            where T : unmanaged
        {
            var sw = Time.stopwatch();
            var variations = from i in gAlg.stream(count)
                    let seed = PolySeed1024.Entropic
                    let evolve = TimeSeries.evolve(seed, domain, steps)
                    let status = evolve.ContinueWith(t => receiver(t.Result))
                    select evolve;

            await root.task(() => Task.WaitAll(variations.ToArray()));
        }

        static SeriesEvolution<T> run<T>(in ulong[] seed, in Interval<T> domain, int steps)
            where T : unmanaged
        {
            var sw = Time.stopwatch();

            var series = define(domain, seed);
            var s0 = series.Snapshot();
            var terms = series.Terms().ToSpan(steps);
            root.invariant(terms.Length == steps, () => "");
            root.invariant(series.Observed.Observed.Equals(terms[steps - 1].Observed), () => "");

            var elapsed = Duration.init(sw.ElapsedTicks);
            return evolution(seed, domain, s0.Observed, series.Observed, elapsed);
        }
    }
}