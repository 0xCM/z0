//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Threading;
    using System.Threading.Tasks;

    using static Konst;

    [ApiHost]
    public readonly struct Fsm
    {
        static int MachineCounter = 0;

        const NumericKind Closure = UInt16k;

        /// <summary>
        /// Creates a machine context
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline), Op]
        public static IFsmContext context(IPolyrand random, ulong? receiptLimit = null)
            => new FsmContext(random, receiptLimit);

        /// <summary>
        /// Defines a primal state machine
        /// </summary>
        /// <param name="classifier">An identifier that defines a membership class that is propagaged to all machines predicated on the specification</param>
        /// <param name="states">The number of states the machine will support</param>
        /// <param name="events">The number of events the machine will recognize</param>
        /// <param name="minSamples">The minimum number of events that will be sampled for each state</param>
        /// <param name="maxSamples">The maximum number of events that will be sampled for each state</param>
        /// <param name="maxReceipts">The maximum number of events that the machine will accept</param>
        /// <typeparam name="T">A scalar type of sufficient size to accommodate specified characteristics</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PrimalFsmSpec<T> primal<T>(string classifier, T states, T events, T minSamples, T maxSamples, ulong maxReceipts)
            where T : unmanaged
                => new PrimalFsmSpec<T>(classifier, states, events, minSamples, maxSamples, maxReceipts);

        /// <summary>
        /// Creates a primal FSM according to a supplied spec with a specified random seed and stream index
        /// </summary>
        /// <param name="spec">The FSM definition</param>
        /// <param name="seed">The rng seed</param>
        /// <param name="index">The rng stream index</param>
        /// <typeparam name="T">The primal fsm type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fsm<T,T> create<T>(PrimalFsmSpec<T> spec, ulong seed, ulong index)
            where T : unmanaged
        {
            var random = Rng.pcg64(seed, index);
            var context = Fsm.context(random, spec.ReceiptLimit);
            return Fsm.machine(identify(spec), context, spec.StartState, spec.EndState, transition(context, spec));
        }

        /// <summary>
        /// Creates a primal FSM according to a supplied spec with a specified random seed and stream index
        /// </summary>
        /// <param name="spec">The FSM definition</param>
        /// <param name="seed">The rng seed</param>
        /// <param name="index">The rng stream index</param>
        /// <typeparam name="T">The primal fsm type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fsm<T,T> create<T>(IWfShell wf, PrimalFsmSpec<T> spec, ulong seed, ulong index)
            where T : unmanaged
                => create(wf, spec);

        [MethodImpl(Inline), Op, Closures(Closure)]
        static string identify<T>(PrimalFsmSpec<T> spec)
            where T : unmanaged
                => $"{spec.Classifier}-{Interlocked.Increment(ref MachineCounter)}";

        /// <summary>
        /// Creates a primal FSM according to a supplied spec with a specified random seed and stream index
        /// </summary>
        /// <param name="spec">The FSM definition</param>
        /// <typeparam name="T">The primal fsm type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Fsm<T,T> create<T>(IWfShell wf, PrimalFsmSpec<T> spec)
            where T : unmanaged
                => Fsm.machine(identify(spec), wf, spec.StartState, spec.EndState, transition(wf.Random, spec), spec.ReceiptLimit);

        /// <summary>
        /// Executes one or more primal state machines
        /// </summary>
        /// <param name="spec">The FSM spec that determines machine characteristics </param>
        /// <param name="machineCount">The number of machines to execute</param>
        /// <param name="sequential">Specifies whether the machines will be executed sequentially</param>
        /// <typeparam name="T">The primal type</typeparam>
        [Op, Closures(Closure)]
        public static IEnumerable<FsmStats> run<T>(PrimalFsmSpec<T> spec, int machineCount, bool sequential = false)
            where T : unmanaged
        {
            var seeds = Entropy.Values<ulong>(machineCount);
            var indices = Algorithmic.stream(0xFFFFul, 0xFFFFFFFFul).Where(x => x % 2 != 0).Take(machineCount).ToArray();
            if(sequential)
                return Fsm.sequential(spec, seeds, indices).Force();
            else
                return concurrent(spec,seeds, indices).Force();
        }

        /// <summary>
        /// Executes the specified machines concurrently
        /// </summary>
        /// <param name="spec">The machine definition</param>
        /// <param name="seeds">The rng seeds that determine initial states of the randomizers</param>
        /// <param name="indices">The rng stream position indices</param>
        /// <typeparam name="T">The primal FSM type</typeparam>
        [Op, Closures(Closure)]
        static IEnumerable<FsmStats> concurrent<T>(PrimalFsmSpec<T> spec, Span<ulong> seeds, Span<ulong> indices)
            where T : unmanaged
        {
            var stats = new ConcurrentBag<FsmStats>();
            var tasks = new Task[seeds.Length];
            for(var i=0; i< tasks.Length; i++)
            {
                var machine = create(spec, seeds[i],indices[i]);
                tasks[i] = Fsm.run(machine).ContinueWith(t => t.Result.OnSome(s => stats.Add(s)));
            }

            Task.WaitAll(tasks);
            return stats;
        }

        /// <summary>
        /// Executes the specified machines sequentially
        /// </summary>
        /// <param name="spec">The machine definition</param>
        /// <param name="seeds">The rng seeds that determine initial states of the randomizers</param>
        /// <param name="indices">The rng stream position indices</param>
        /// <typeparam name="T">The primal FSM type</typeparam>
        [Op, Closures(Closure)]
        static IEnumerable<FsmStats> sequential<T>(PrimalFsmSpec<T> spec, Span<ulong> seeds, Span<ulong> indices)
            where T : unmanaged
        {
            var stats = new ConcurrentBag<FsmStats>();
            for(var i=0; i< seeds.Length; i++)
            {
               var machine = create(spec, seeds[i], indices[i]);
               var result = Fsm.run(machine).Result;
               result.OnSome(s => stats.Add(s));
            }
            return stats;
        }

        [Op, Closures(Closure)]
        static MachineTransition<T,T> transition<T>(IFsmContext context, PrimalFsmSpec<T> spec)
            where T : unmanaged
        {
            var sources = Algorithmic.stream<T>(spec.StateCount).ToArray();
            var random = context.Random;
            var rules = new List<TransitionRule<T,T>>();
            foreach(var source in sources)
            {
                var evss = random.Next<T>(spec.MinEventSamples, spec.MaxEventSamples);
                var targets = from t in random.Distinct(spec.StateCount, evss) where gmath.neq(t,source) select t;
                var events = random.Distinct(spec.EventCount, evss);
                rules.AddRange(events.Zip(targets).Select(x => Fsm.transition(x.First, source, x.Second)));
            }
            return rules.ToFunction();
        }

        [Op, Closures(Closure)]
        static MachineTransition<T,T> transition<T>(IPolyrand random, PrimalFsmSpec<T> spec)
            where T : unmanaged
        {
            var sources = Algorithmic.stream<T>(spec.StateCount).ToArray();
            var rules = new List<TransitionRule<T,T>>();
            foreach(var source in sources)
            {
                var evss = random.Next<T>(spec.MinEventSamples, spec.MaxEventSamples);
                var targets = from t in random.Distinct(spec.StateCount, evss) where gmath.neq(t,source) select t;
                var events = random.Distinct(spec.EventCount, evss);
                rules.AddRange(events.Zip(targets).Select(x => Fsm.transition(x.First, source, x.Second)));
            }
            return rules.ToFunction();
        }

        /// <summary>
        /// Defines a single state transition rule of the form (trigger : E, source : S) -> target : S
        /// </summary>
        /// <param name="trigger">The incoming event</param>
        /// <param name="source">The source state</param>
        /// <param name="target">The target state</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static TransitionRule<E,S> transition<E,S>(E trigger, S source, S target)
            => new TransitionRule<E,S>(trigger,source,target);

        /// <summary>
        /// Defines a machine transition function (trigger : E, source: S) -> target : S
        /// that determines machine transition behavior
        /// </summary>
        /// <param name="rules">The rules that comprise the function</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static MachineTransition<E,S> transition<E,S>(IEnumerable<ITransitionRule<E,S>> rules)
            => new MachineTransition<E,S>(rules);

        /// <summary>
        /// Defines an output rule of the form (trigger : E, source : S) -> output : O
        /// that specifies that output to emit when an input is received when in the source state
        /// </summary>
        /// <param name="trigger">The triggering event</param>
        /// <param name="source">The source state</param>
        /// <param name="output">The output value</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static OutputRule<E,S,O> output<E,S,O>(E trigger, S source, O output)
            => (trigger, source, output);

        /// <summary>
        /// Defines a machine transition function (trigger : E, source: S) -> target : S
        /// that determines machine transition behavior
        /// </summary>
        /// <param name="rules"></param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static MachineOutput<E,S,O> output<E,S,O>(IEnumerable<IOutputRule<E,S,O>> rules)
            => new MachineOutput<E, S, O>(rules);

        /// <summary>
        /// Defines an action that fires upon state entry
        /// </summary>
        /// <param name="source">The source state</param>
        /// <param name="target">The the entry action</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        [MethodImpl(Inline)]
        public static ActionRule<S,A> entry<S,A>(S source, A action)
            => new ActionRule<S,A>(source,action);

        /// <summary>
        /// Defines an entry action function
        /// </summary>
        /// <param name="rules">The state entry rules</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        [MethodImpl(Inline)]
        public static EntryFunction<S,A> entry<S,A>(IEnumerable<IFsmActionRule<S,A>> rules)
            => new EntryFunction<S, A>(rules);

        /// <summary>
        /// Defines an action that fires upon state exit
        /// </summary>
        /// <param name="source">The source state</param>
        /// <param name="target">The the exit action</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        [MethodImpl(Inline)]
        public static ActionRule<S,A> exit<S,A>(S source, A action)
            => new ActionRule<S,A>(source,action);

        /// <summary>
        /// Defines an exit action function
        /// </summary>
        /// <param name="rules">The state exit rules</param>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The action type</typeparam>
        [MethodImpl(Inline)]
        public static ExitFunction<S,A> exit<S,A>(IEnumerable<IFsmActionRule<S,A>> rules)
            => new ExitFunction<S,A>(rules);

        /// <summary>
        /// Defines the most basic FSM, predicated only on ground-state, end-state and transition function
        /// </summary>
        /// <param name="id">Identifies the machine within the context of the executing process</param>
        /// <param name="s0">The ground-state</param>
        /// <param name="sZ">The end-state</param>
        /// <param name="f">The transition function</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static Fsm<E,S> machine<E,S>(string id, IFsmContext context, S s0, S sZ, MachineTransition<E,S> f)
            => new Fsm<E,S>(id, context, s0, sZ, f);

        /// <summary>
        /// Defines the most basic FSM, predicated only on ground-state, end-state and transition function
        /// </summary>
        /// <param name="id">Identifies the machine within the context of the executing process</param>
        /// <param name="s0">The ground-state</param>
        /// <param name="sZ">The end-state</param>
        /// <param name="f">The transition function</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static Fsm<E,S> machine<E,S>(string id, IWfShell wf, S s0, S sZ, MachineTransition<E,S> f, ulong? limit = null)
            => new Fsm<E,S>(id, wf, s0, sZ, f, limit);

        /// <summary>
        /// Defines an output rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static OutputRuleKey<E,S> outKey<E,S>(E trigger, S source)
            => (trigger,source);

        /// <summary>
        /// Defines an entry rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static ActionRuleKey<S> entryKey<S>(S source)
            => source;

        /// <summary>
        /// Defines an exit rule key
        /// </summary>
        /// <param name="source">The antecedent state</param>
        /// <param name="input">The output value</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static ActionRuleKey<S> exitKey<S>(S source)
            => source;

        /// <summary>
        /// Defines a key for a transition rule
        /// </summary>
        /// <param name="trigger">The triggering event</param>
        /// <param name="source">The source state</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static TransitionRuleKey<E,S> transitionKey<E,S>(E trigger, S source)
            => (trigger,source);

        /// <summary>
        /// Defines a machine that supports entry/exit actions on a per-state basis
        /// </summary>
        /// <param name="id">Identifies the machine within the context of the executing process</param>
        /// <param name="s0">The ground-state</param>
        /// <param name="sZ">The end-state</param>
        /// <param name="t">The transition function</param>
        /// <param name="entry">The entry function</param>
        /// <param name="exit">The exit function</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        /// <typeparam name="A">The entry action type</typeparam>
        [MethodImpl(Inline)]
        public static Fsm<E,S,A> machine<E,S,A>(string id, IWfShell wf, IPolyrand random, S s0, S sZ, MachineTransition<E,S> t, EntryFunction<S,A> entry, ExitFunction<S,A> exit, ulong? limit = null)
            => new Fsm<E,S,A>(id, wf, random, s0, sZ, t, entry,exit, limit);

        /// <summary>
        /// Creates a default machine observer
        /// </summary>
        /// <param name="fsm">The machine under observation</param>
        /// <param name="trace">Whether to emit trace messages</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static FsmObserver<E,S> observer<E,S>(Fsm<E,S> fsm, ObserverTrace? tracing = null)
            => new FsmObserver<E,S>(fsm, tracing);

        /// <summary>
        /// Runs a machine
        /// </summary>
        /// <param name="context">The machine context</param>
        /// <param name="machine">The specified machine</param>
        /// <typeparam name="E">The event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        public static Task<Option<FsmStats>> run<E,S>(Fsm<E,S> machine)
            => Task.Factory.StartNew(() => RunMachine(machine));

        static Option<FsmStats> RunMachine<E,S>(Fsm<E,S> machine)
        {
            try
            {
                var random = machine.Random;
                var o = Fsm.observer(machine, ObserverTrace.Completions | ObserverTrace.Errors);
                var events = machine.Triggers.ToArray();
                var domain = Interval.closed(0, events.Length);
                var eventstream = random.Stream(domain).Select(i => events[i]);
                machine.Start();
                while(!machine.Finished)
                    machine.Submit(eventstream.First());
                return machine.QueryStats();
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        /// <summary>
        /// Forms a transition function from a sequence of transition rules
        /// </summary>
        /// <param name="rules">The individual rules that will comprise the function</param>
        /// <typeparam name="E">The input event type</typeparam>
        /// <typeparam name="S">The state type</typeparam>
        [MethodImpl(Inline)]
        public static MachineTransition<E,S> transition<E,S>(params TransitionRule<E,S>[] rules)
            => new MachineTransition<E,S>(rules);
    }
}