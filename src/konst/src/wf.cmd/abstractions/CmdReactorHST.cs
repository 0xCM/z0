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

    [CmdReactor]
    public abstract class CmdReactor<S,T> : ICmdReactor<S,T>
        where S : struct, ICmdSpec<S>
        where T : struct
    {
        protected WfHost Host;

        protected IWfShell Wf;

        protected IFileDb Db => Wf.Db();

        public static S Spec() => new S();

        public CmdId CmdId => Spec().Id;

        protected abstract T Run(S cmd);

        public CmdResult<T> Invoke(S cmd)
        {
            try
            {
                return new CmdResult<T>(cmd.Id, true, Run(cmd));
            }
            catch(Exception e)
            {
                Wf.Error(e);
                return new CmdResult<T>(cmd.Id, false);
            }
        }

        public void Init(IWfShell wf)
        {
            Host = WfShell.host(GetType());
            Wf = wf.WithHost(Host);
        }

        ClrArtifactKey IWfService.ServiceId
            => GetType().MetadataToken;
    }

    [CmdReactor]
    public abstract class CmdReactor<H,S,T> : CmdReactor<S,T>
        where H : CmdReactor<H,S,T>, new()
        where S : struct, ICmdSpec<S>
        where T : struct
    {

        public static H Create(IWfShell wf)
        {
            var node = new H();
            node.Init(wf);
            return node;
        }
    }
}