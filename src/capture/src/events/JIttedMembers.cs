//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct JittedMembers : IWfEvent<JittedMembers>
    {            
        public const string EventName = nameof(JittedMembers);
        
        public WfEventId Id {get;}

        public string ActorName {get;}
        
        public readonly IApiHost[] Hosts;

        public readonly ApiMember[] Members;

        [MethodImpl(Inline)]
        public JittedMembers(IApiHost[] hosts, ApiMember[] members, [CallerMemberName] string actor = null)
        {
            Id = wfid(EventName);
            ActorName = actor;
            Hosts = hosts;
            Members = members;
        }

        public object Description
            => new {MemberCount = Members.Length, HostCount = Hosts.Length};
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);
    }    
}