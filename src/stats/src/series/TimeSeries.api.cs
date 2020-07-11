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
    using System.Threading;
    using System.Threading.Tasks;

    using static Konst;
    using static Memories;

    public static class TimeSeries
    {
        static long LastSeriesId;

        static readonly ConcurrentDictionary<long, IPolyrand> States
            = new ConcurrentDictionary<long, IPolyrand>();

        public static SeriesTerm<T> Term<T>(long index, T value)
            where T : unmanaged
                => new SeriesTerm<T>(index, value);  

        public static SeriesTerm<T> NextTerm<T>(TimeSeries<T> series)      
            where T : unmanaged
        {
            if(States.TryGetValue(series.Id, out IPolyrand random))
            {                
                var term = Term(series.Observed.Index + 1, random.Next<T>(series.Domain));
                series.Witnessed(term);
                return term;
            }
            else
                return series.Observed;
        }

        internal static IEnumerable<SeriesTerm<T>> Evolve<T>(TimeSeries<T> series)
            where T : unmanaged
        {
            if(States.TryGetValue(series.Id, out IPolyrand random))
            {                
                while(true)
                {
                    var term = Term(series.Observed.Index + 1, random.Next<T>(series.Domain));
                    series.Witnessed(term);
                    yield return term;
                }
            }
        }

        public static TimeSeries<T> Define<T>(Interval<T> domain, ulong[] seed)
            where T : unmanaged
        {
            var id = atomic(ref LastSeriesId);
            var rng = Polyrand.XOrShift1024(seed);
            if(!States.TryAdd(id,rng))
                throw new Exception($"Key {id} already exists");
            return new TimeSeries<T>(id, domain, Term(0, As.zero<T>()));
        }

        public static void EvolveSeries<T>(Interval<T> domain, ulong[] seed, int count, Action<TimeSeries<T>,Duration> complete)
            where T : unmanaged
        {            
            var sw = Time.stopwatch();
            var series = Define(domain, seed); 
            var terms = series.Terms().ToSpan(count);
            var elapsed = Duration.Define(sw.ElapsedTicks);
            Demands.insist(terms.Length == count);
            Demands.insist(series.Observed.Observed.Equals(terms[count - 1].Observed));
            complete(series,elapsed);
        }

        static SeriesEvolution<T> Execute<T>(in ulong[] seed, in Interval<T> domain, int steps)
            where T : unmanaged
        {
            var sw = Time.stopwatch();
            
            var series = Define(domain, seed); 
            var s0 = series.Snapshot();                     
            var terms = series.Terms().ToSpan(steps);
            Demands.insist(terms.Length == steps);
            Demands.insist(series.Observed.Observed.Equals(terms[steps - 1].Observed));
            
            var elapsed = Duration.Define(sw.ElapsedTicks);
            var evolved = SeriesEvolution.Define(seed, domain, s0.Observed, series.Observed, elapsed);
            return evolved;            
        }

        public static Task<SeriesEvolution<T>> Evolve<T>(ulong[] seed, Interval<T> domain, int steps)
            where T : unmanaged        
            => Task.Factory.StartNew(() => Execute(seed, domain, steps));    
        
        public static async Task Evolve<T>(Interval<T> domain, Action<SeriesEvolution<T>> receiver, int count = Pow2.T06, int steps = (int)Pow2.T19)
            where T : unmanaged
        {
            var sw = Time.stopwatch();
            var variations = from i in gmath.range(count) 
                    let seed = PolySeed1024.Entropic
                    let evolve = TimeSeries.Evolve(seed, domain, steps)
                    let status = evolve.ContinueWith(t => receiver(t.Result))
                    select evolve;
            
            await task(() => Task.WaitAll(variations.ToArray()));
        }
    }
}