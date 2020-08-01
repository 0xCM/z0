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

    public struct MachineContext : IWorkflowContext<MachineWorkflowConfig>
    {
        public IAppContext ContextRoot {get;}
        
        public MachineWorkflowConfig ContextData {get;}

        [MethodImpl(Inline)]
        public static implicit operator MachineContext(WorkflowContext<MachineWorkflowConfig> src)
            => new MachineContext(src.ContextRoot, src.ContextData);
        
        [MethodImpl(Inline)]
        public MachineContext(IAppContext root, MachineWorkflowConfig config)
        {
            ContextRoot = root;
            ContextData = config;
        }

        public TAppPaths AppPaths
        {
            get => ContextRoot.AppPaths;
        }
    }
}