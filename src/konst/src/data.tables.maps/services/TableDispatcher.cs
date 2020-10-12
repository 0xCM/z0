//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct TableDispatcher<F,T,D,S,Y> : ITableDispatcher<F,T,D,S,Y>
        where F : unmanaged
        where T : struct, IKeyedTable<F,T,D>
        where D : unmanaged
        where S : unmanaged
    {
        public IWfShell Wf {get;}

        readonly WfHost Host;

        readonly TableProjectors<D,S,T,Y> Projectors;

        readonly KeyMap<D,S> Selectors;

        [MethodImpl(Inline)]
        public TableDispatcher(IWfShell wf, in TableProjectors<D,S,T,Y> processors, in KeyMap<D,S> selectors)
        {
            Host = WfSelfHost.create(typeof(TableDispatcher<F,T,D,S,Y>));
            Wf = wf.WithHost(Host);
            Projectors = processors;
            Selectors = selectors;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        [MethodImpl(Inline)]
        public void Dispatch(T[] src, Y[] dst)
        {
            try
            {
                Wf.Running();
                using var engine = new TableDispatchEngine<F,T,D,S,Y>(Wf, src, Projectors, Selectors, dst);
                engine.Run();
                Wf.Ran();
            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
            finally
            {
                Wf.Ran();
            }
        }
    }
}