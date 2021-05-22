//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    internal class ApiExtractChannel
    {
        event EventHandler<HostResolvedEvent> HostResolved;

        event EventHandler<PartResolvedEvent> PartResolved;

        event EventHandler<MemberParsedEvent> MemberParsed;

        event EventHandler<MemberDecodedEvent> MemberDecoded;

        event EventHandler<ExtractErrorEvent> ExtractError;

        public void Raise(HostResolvedEvent e)
            => root.run(() => HostResolved.Invoke(this, e));

        public void Raise(PartResolvedEvent e)
            => root.run(() => PartResolved.Invoke(this, e));

        public void Raise(MemberParsedEvent e)
            => root.run(() => MemberParsed.Invoke(this, e));

        public void Raise(MemberDecodedEvent e)
            => root.run(() => MemberDecoded.Invoke(this, e));

        public void Raise(ExtractErrorEvent e)
            => root.run(() => ExtractError.Invoke(this, e));

        public void Enlist(ApiExtractWorkflow receiver)
        {
            PartResolved += (source, e) => receiver.Deposit(e);
            HostResolved += (source, e) => receiver.Deposit(e);
            MemberParsed += (source, e) => receiver.Deposit(e);
            MemberDecoded += (source, e) => receiver.Deposit(e);
            ExtractError += (source, e) => receiver.Deposit(e);
        }
    }
}