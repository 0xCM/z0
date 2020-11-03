//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public class Controls
    {
        readonly IWfShell Wf;

        readonly CmdWorkers Workers;

        public static Controls create(IWfShell wf)
        {
            var dst = new Controls(wf);

            return dst;
        }

        Controls(IWfShell wf)
        {
            Wf = wf;
            Workers = CmdWorkers.create();
        }

        void Discover()
        {
            var nodes = @readonly(Wf.Components);
            var count = nodes.Length;
            for(var i=0; i<count; i++)
                Visit(skip(nodes,i));
        }

        void Visit(Assembly src)
        {
            var nodes = @readonly(src.GetTypes());
            var count = nodes.Length;
            for(var i=0; i<count; i++)
                Visit(skip(nodes,i));
        }

        void Visit(Type src)
        {
            var nodes = @readonly(src.StaticMethods());
            var count = nodes.Length;
            for(var i=0; i<count; i++)
                Visit(skip(nodes,i));

        }

        void Visit(MethodInfo src)
        {
            if(src.Tagged<CmdWorkerAttribute>())
            {

            }
        }

    }

    public sealed class CmdWorkers : ConcurrentDictionary<Type,MethodInfo>
    {
        public static CmdWorkers create(params KeyedValue<Type,MethodInfo>[] src)
        {
            var dst = new CmdWorkers();
            iter(src, kv => dst.TryAdd(kv.Key, kv.Value));
            return dst;
        }
    }
}