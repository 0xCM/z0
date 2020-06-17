//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using E = MachineEvents.IndexedCode;

    partial class MachineEvents
    {
        public readonly struct IndexedCode : IMachineEvent<E>
        {
            public static E Empty => new E(MachineIndex.Empty);

            [MethodImpl(Inline)]
            public static IndexedCode Create(MachineIndex index)
                => new IndexedCode(index);            

            [MethodImpl(Inline)]
            public IndexedCode(MachineIndex index)
            {
                Index = index;
            }
            
            public MachineIndex Index {get;}

            public AppMsgColor Flair => AppMsgColor.Cyan;
            
            public E Zero => Empty; 
            
            public string Description
                => $"{Index.EntryCount} entries created in the code index";
        }        
    }
}