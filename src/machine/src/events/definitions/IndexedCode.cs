//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = MachineEvents.IndexedCode;

    public partial class MachineEvents
    {
        public readonly struct IndexedCode : IMachineEvent<E>
        {
            public static E Empty => new E(UriCodeIndex.Empty);

            [MethodImpl(Inline)]
            public static IndexedCode Create(UriCodeIndex index)
                => new IndexedCode(index);            

            [MethodImpl(Inline)]
            public IndexedCode(UriCodeIndex index)
            {
                Index = index;
            }
            
            public UriCodeIndex Index {get;}

            public AppMsgColor Flair => AppMsgColor.Cyan;
            
            public E Zero => Empty; 
            
            public string Description
                => $"{Index.EntryCount} entries created in the code index";
        }        
    }
}