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
        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly IApiHost[] Hosts;

        public readonly ApiMember[] Members;

        [MethodImpl(Inline)]
        public JittedMembers(IApiHost[] hosts, ApiMember[] members)
        {
            Hosts = hosts;
            Members = members;
        }

        public string Format()
            => $"Jitted {Members.Length} members from {Hosts.Length} api hosts";
    }    
}