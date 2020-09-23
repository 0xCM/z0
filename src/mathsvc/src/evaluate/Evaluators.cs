//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Evaluators
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPolyrand Source;

        readonly uint SampleCount;

        public Evaluators(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Source = wf.Random;
            SampleCount = Pow2.T14;
        }

        [Op]
        public void Run()
        {
            var svc = MSvc.and<byte>();
            var input = Source.Pairings<byte,byte>(SampleCount);
            var output = Tuples.pairs<byte>(SampleCount);
            Run(input, svc,svc, output);
        }

        [MethodImpl(Inline)]
        void Run<T0,T1,R,F,G>(in Pairings<T0,T1> src, F f, G g, Pairs<R> dst)
            where T0: unmanaged
            where T1: unmanaged
            where R : unmanaged
            where F : IFunc<T0,T1,R>
            where G : IFunc<T0,T1,R>
                => default(BinaryEvaluator<T0,T1,R>).Evaluate(src,f,g,dst);

        public readonly struct BinaryEvaluator<T0,T1,R>
            where T0: unmanaged
            where T1: unmanaged
            where R : unmanaged
        {
            [MethodImpl(Inline)]
            public void Evaluate<F,G>(Pairings<T0,T1> src, F f, G g, Pairs<R> dst)
                where F : IFunc<T0,T1,R>
                where G : IFunc<T0,T1,R>
            {
                var count = src.Count;
                for(var i=0; i<count; i++)
                {
                    ref readonly var p = ref src[i];
                    var r1 = f.Invoke(p.Left,p.Right);
                    var r2 = g.Invoke(p.Left,p.Right);
                    dst[i] = (r1,r2);
                }
            }
        }

    }

    /*

    public sealed class WfTestHost : WfHost<WfTestHost>
    {
        protected override void Execute(IWfShell wf)
        {
            try
            {
                var eval = new Evaluators(wf,this);
                eval.Run();
            }
            catch(Exception e)
            {
                wf.Error(this,e);
            }
        }
    }

    readonly struct App
    {
        public static void Run(params string[] args)
        {

        }

        public static void Main(params string[] args)
        {
            var control = Assembly.GetEntryAssembly();
            var modules = Flow.modules(control, args);
            var context = Flow.context(control, modules, args);
            var wfInit = new WfInit(context, args, modules);
            var settings = wfInit.Settings;
            using var wf = Polyrand.install(Flow.shell(wfInit));
            new WfTestHost().Run(wf);
        }

    }
    */
}