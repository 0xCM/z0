//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;
    using static z;

    public readonly struct HexCodeSaved : IWfEvent<HexCodeSaved>
    {
        public const string EventName = nameof(HexCodeSaved);
        
        public WfEventId EventId {get;}
    
        public WfActor Actor {get;}

        public readonly ApiHostUri Host;
        
        public readonly IdentifiedCode[] Code;

        public readonly CellCount MemberCount;
        
        public readonly FilePath Target;

        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public HexCodeSaved(string actor, ApiHostUri host, IdentifiedCode[] code, FilePath dst, CorrelationToken ct, MessageFlair flair = Ran)
        {
            EventId = evid(EventName, ct);
            Actor = WfCore.actor(actor);
            Host = host;
            MemberCount = code.Length;
            Code = code;
            Target = dst;
            Flair = flair;
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Host, MemberCount, Target);                   
    }    
}