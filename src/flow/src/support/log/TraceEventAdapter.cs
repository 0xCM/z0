//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.Diagnostics.Tracing;
    using Microsoft.Diagnostics.Tracing.Session;
    using System.Linq.Expressions;

    public static class TraceEventAdapter
    {
        public static T Payload<T>(this TraceEvent e, string name)
            => (T)e.PayloadByName(name);

        public static dynamic Payload<T>(this TraceEvent e, Expression<Func<T,dynamic>> selector)
            => e.PayloadByName(selector.GetAccessedProperty().Name);

        public static AgentEventId EventIdentity(this TraceEvent data)
                => Z0.AgentEventId.define(
                data.Payload<uint>("ServerId"),
                data.Payload<uint>("AgentId"),
                data.Payload<ulong>("Timestamp"),
                data.Payload<ulong>("EventKind")
                );

        public static A Adapt<A>(this TraceEvent e)
            where A : TraceEventAdapter<A>, new()
        {
            var adapter = new A();
            adapter.Subject = e;
            return adapter;
        }
    }

    public abstract class TraceEventAdapter<A>
        where A : TraceEventAdapter<A>, new()
    {
        public TraceEvent Subject {get; set;}

        public AgentEventId EventIdentity
            => Subject.EventIdentity();

        public T Field<T>(string Name)
            => Subject.Payload<T>(Name);
    }

    public abstract class TraceEventAdapter<A,T> : TraceEventAdapter<A>
        where A : TraceEventAdapter<A,T>, new()
        where T : unmanaged
    {
        public virtual T Body
            => z.cell<T>(Subject.Payload<byte[]>(nameof(Body)).ToSpan());
    }
}