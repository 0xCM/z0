//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct JittedMembers : IAppEvent<JittedMembers>
    {            
        public readonly IApiHost[] Hosts;

        public readonly ApiMember[] Members;

        [MethodImpl(Inline)]
        public JittedMembers(IApiHost[] hosts, ApiMember[] members)
        {
            Hosts = hosts;
            Members = members;
        }

        public string Description
            => $"Jitted {Members.Length} members from {Hosts.Length} api hosts";
    }    
}