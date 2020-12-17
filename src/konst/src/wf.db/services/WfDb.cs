//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [WfService]
    public sealed class WfDb : WfService<WfDb,IWfDb>, IWfDb
    {        
        public FS.FolderPath Root {get; private set;}

        public WfDb()
        {

        }

        [MethodImpl(Inline)]
        internal WfDb(IWfShell wf)
            : base(wf)
        {
            Root = Wf.DbRoot;
        }

        protected override void OnInit()
        {
            Root = Wf.DbRoot;
        } 
    }
}