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
    public readonly struct AsmFunctionGroup
    {        
        public readonly OpIdentity Id;

        public readonly AsmFunction[] Members;
    
        [MethodImpl(Inline)]
        public AsmFunctionGroup(OpIdentity id, AsmFunction[] members)
        {
            Id = id;
            Members = members;            
        }

        [MethodImpl(Inline)]
        public AsmFunctionGroup(GenericOpIdentity id, AsmFunction[] members)
        {
            Id = id.Generialize();
            Members = members;            
        }

        public string Format() 
            => Id.Identifier;
    }
}