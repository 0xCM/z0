//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a group of assembly functions related by an operation identity
    /// </summary>
    public readonly struct AsmRoutineGroup
    {        
        public readonly OpIdentity Id;

        public readonly AsmRoutine[] Members;
    
        [MethodImpl(Inline)]
        public AsmRoutineGroup(OpIdentity id, AsmRoutine[] members)
        {
            Id = id;
            Members = members;            
        }

        [MethodImpl(Inline)]
        public AsmRoutineGroup(GenericOpIdentity id, AsmRoutine[] members)
        {
            Id = id.Generialize();
            Members = members;            
        }

        public string Format() 
            => Id.Identifier;
    }
}