//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Reflection;
        
    using static Konst;
    using static z;

    public readonly struct WorkflowConfig
    {
        public static WorkflowConfig load(IAppContext context)
        {
            var path = WorkflowContext.ConfigPath(context);
            var dst = z.dict<string,string>();
            AppSettings.absorb(path,dst);
            var config = new WorkflowConfig(dst);
            context.Deposit(new LoadedWorkflowConfig(path,config));
            return config;
        }

        readonly KeyedValues<string,string> Index;
        
        [MethodImpl(Inline)]
        public WorkflowConfig(KeyedValue<string,string>[] src)
            => Index = new KeyedValues<string,string>(src);

        [MethodImpl(Inline)]
        public WorkflowConfig(Dictionary<string,string> src)
            => Index = KeyedValues.from(src);

        public string this[string key]
        {
            [MethodImpl(Inline)]
            get => Index.Search(key, out var value) ? value : EmptyString;
        }
    }
}