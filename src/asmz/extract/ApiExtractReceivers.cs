//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    using Z0.Asm;

    public abstract class ApiExtractEvent<E> : IWfEvent<E>
        where E : ApiExtractEvent<E>, new()
    {
        public EventId EventId {get;}

        public FlairKind Flair {get;}

        protected ApiExtractEvent()
        {
            EventId = typeof(E);
            Flair = FlairKind.Processed;
        }

        public string Format()
        {
            return EmptyString;
        }
    }

    public abstract class ApiExtractEvent<E,P> : ApiExtractEvent<E>
        where E : ApiExtractEvent<E,P>, new()
    {

        protected ApiExtractEvent()
        {

        }

        public P Payload {get; protected set;}
    }

    public class ApiExtractReceivers
    {
        public event EventHandler<HostResolvedEvent> HostResolved;

        public event EventHandler<PartResolvedEvent> PartResolved;

        public event EventHandler<MemberParsedEvent> MemberParsed;

        public event EventHandler<MemberDecodedEvent> MemberDecoded;

        public event EventHandler<MemberParseErrorEvent> MemberParseError;

        internal void Raise(HostResolvedEvent e)
        {
            root.run(() =>  HostResolved.Invoke(this, e));
        }

        internal void Raise(PartResolvedEvent e)
        {
            root.run(() =>  PartResolved.Invoke(this, e));
        }

        internal void Raise(MemberParsedEvent e)
        {
            root.run(() =>  MemberParsed.Invoke(this, e));
        }

        public sealed class HostResolvedEvent : ApiExtractEvent<HostResolvedEvent,ResolvedHost>
        {
            public HostResolvedEvent()
            {
                Payload = ResolvedHost.Empty;
            }

            public HostResolvedEvent(in ResolvedHost src)
            {
                Payload = src;
            }
        }

        public sealed class PartResolvedEvent : ApiExtractEvent<PartResolvedEvent,ResolvedPart>
        {

            public PartResolvedEvent()
            {
                Payload = ResolvedPart.Empty;
            }

            public PartResolvedEvent(in ResolvedPart src)
            {
                Payload = src;
            }

        }

        public sealed class MemberParsedEvent : ApiExtractEvent<MemberParsedEvent,DataFlow<ApiMemberExtract,ApiMemberCode>>
        {
            public MemberParsedEvent()
            {
                Payload = Relations.flow(ApiMemberExtract.Empty, ApiMemberCode.Empty);

            }

            public MemberParsedEvent(in ApiMemberExtract src, in ApiMemberCode dst)
            {
                Payload = Relations.flow(src,dst);
            }

        }

        public sealed class MemberDecodedEvent : ApiExtractEvent<MemberDecodedEvent,DataFlow<ApiMemberCode,AsmRoutine>>
        {
            public MemberDecodedEvent()
            {
                Payload = Relations.flow(ApiMemberCode.Empty, AsmRoutine.Empty);
            }

            public MemberDecodedEvent(in ApiMemberCode src, in AsmRoutine dst)
            {
                Payload = Relations.flow(src,dst);

            }
        }

        public sealed class MemberParseErrorEvent : ApiExtractEvent<MemberParseErrorEvent,ApiMemberExtract>
        {
            public MemberParseErrorEvent()
            {
                Payload = ApiMemberExtract.Empty;
            }

            public MemberParseErrorEvent(in ApiMemberExtract src)
            {
                Payload = src;
            }
        }
    }
}