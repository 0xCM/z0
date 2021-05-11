//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    public class ApiExtractReceipt
    {
        public event EventHandler<HostResolvedEvent> HostResolved;

        public event EventHandler<PartResolvedEvent> PartResolved;

        public event EventHandler<MemberParsedEvent> MemberParsed;

        public event EventHandler<MemberDecodedEvent> MemberDecoded;

        public event EventHandler<ExtractErrorEvent> ExtractError;

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

        internal void Raise(MemberDecodedEvent e)
        {
            root.run(() =>  MemberDecoded.Invoke(this, e));
        }

        internal void Raise(ExtractErrorEvent e)
        {
            root.run(() =>  ExtractError.Invoke(this, e));
        }
    }
}