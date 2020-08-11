//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static Flow;
    using static z;

    [Event]
    public readonly struct CapturedResourceSets : IWfEvent<CapturedResourceSets>
    {
        public const string EventName = nameof(CapturedResourceSets);

        public WfEventId EventId {get;}

        public WfActor Actor {get;}
        
        public CellCount Count {get;}
        
        public FilePath Source {get;}
        
        public FolderPath Target {get;}
        
        [MethodImpl(Inline)]
        public CapturedResourceSets(string actor, CapturedAccessor[] data, FilePath src, FolderPath dst,  CorrelationToken? ct = null)
        {
            EventId = evid(EventName,ct ?? CorrelationToken.Empty);
            Actor = actor;
            Count = data.Length;
            Source = src;
            Target = dst;
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Actor, Count, Target);
    }
}