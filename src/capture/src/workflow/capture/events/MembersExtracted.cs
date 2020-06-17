//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using E = CaptureWorkflowEvents.MembersExtracted;

    partial class CaptureWorkflowEvents
    {
        public readonly struct MembersExtracted : IAppEvent<E>
        {
            public static E Empty => new E(ApiHostUri.Empty, new ExtractedMember[]{});

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri host, ExtractedMember[] members)
                => new E(host, members);

            [MethodImpl(Inline)]
            MembersExtracted(ApiHostUri host, ExtractedMember[] extracted)
            {
                this.Host = host;
                this.Extracts = extracted;
            }
            
            public ApiHostUri Host {get;}
            
            public ExtractedMember[] Extracts {get;}

            public string Description
                => $"{Extracts.Length} {Host} members extracted";

            public E Zero => Empty; 
        }    
    }
}