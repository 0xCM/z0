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

    public struct WorkflowContext : IWorkflowContext
    {
        public static FilePath ConfigPath(IAppContext context)
        {
            var filename = FileName.Define(Assembly.GetEntryAssembly().GetSimpleName(), FileExtensions.Json);
            var src = context.AppPaths.ConfigRoot + filename;
            return src;
        }
        
        public static WorkflowContext<T> load<T>(IAppContext root, FilePath src)
            where T : struct
                => create(root, AppSettings.load<T>(src));

        public static WorkflowContext<T> load<T>(IAppContext root)
            where T : struct
        {
            var src = ConfigPath(root);
            return load<T>(root, src);
        }            

        [MethodImpl(Inline)]
        public static WorkflowContext<T> create<T>(IAppContext root, T data)
            => new WorkflowContext<T>(root, data);

        [MethodImpl(Inline)]
        public static WorkflowContext create(IAppContext root)
            => new WorkflowContext(root);

        public IAppContext ContextRoot {get;}
        
        [MethodImpl(Inline)]
        public WorkflowContext(IAppContext root)
        {
            ContextRoot = root;            
        }
    }    
}