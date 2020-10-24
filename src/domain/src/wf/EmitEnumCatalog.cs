//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [Cmd]
    public struct EmitEnumCatalogCmd : ICmdSpec<EmitEnumCatalogCmd>
    {

    }

    [WfHost]
    public sealed class EmitEnumCatalog : WfHost<EmitEnumCatalog>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitEnumCatalogStep(wf, this);
            step.Run();
        }
    }

    readonly ref struct EmitEnumCatalogStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitEnumCatalogStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
            => EnumCatalogs.emit(Wf);
    }
}