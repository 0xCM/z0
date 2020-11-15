//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public struct CmdPipe : ICmdPipe<CmdPipe>
    {
        IWfShell Wf;

        ConcurrentDictionary<CmdId,ICmdReactor> Nodes;

        public void Init(IWfShell wf)
        {
            Wf = wf;
            Nodes = new ConcurrentDictionary<CmdId, ICmdReactor>();
        }

        public CmdPipe(IWfShell wf)
        {
            Wf =wf;
            Nodes = new ConcurrentDictionary<CmdId, ICmdReactor>();
        }

        public Outcome<T> Process<S,T>(S src)
            where S : struct, ICmdSpec<S>
            where T : struct
        {
            try
            {
                if(Nodes.TryGetValue(src.CmdId, out var node))
                {
                    return (T)node.Process(src);
                }
                else
                {
                    return (false, default(T), 0xA0ul);
                }

            }
            catch(Exception e)
            {
                Wf.Error(e);
                return e;
            }
        }

        public ReadOnlySpan<Outcome<T>> Process<S,T>(ReadOnlySpan<S> src, bool pll)
            where S : struct, ICmdSpec<S>
            where T : struct
        {
            var count = src.Length;
            var dst = span<Outcome<T>>(count);
            if(pll)
            {
                @throw(missing());
            }
            else
            {
                for(var i=0; i<count; i++)
                    seek(dst,i) = Process<S,T>(skip(src,i));
            }
            return dst;
        }

        public Outcome<ValueType> Process(ICmdSpec cmd)
        {
            try
            {
                if(Nodes.TryGetValue(cmd.CmdId, out var node))
                {
                    return node.Process(cmd);
                }
                else
                {
                    return (false, default(ValueType), 0xA0ul);
                }

            }
            catch(Exception e)
            {
                Wf.Error(e);
                return e;
            }
        }
    }
}