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
        [MethodImpl(Inline)]
        public static AsmFunctionGroup Define(OpIdentity id, AsmFunction[] members)
        {            
            Demands.reason(members.Length != 0, $"{id}: Empty groups are disallowed");            
            return new AsmFunctionGroup(id, members);
        }
        
        [MethodImpl(Inline)]
        public static AsmFunctionGroup Define(GenericOpIdentity id, AsmFunction[] members)
            => Define(id.Generialize(), members);

        [MethodImpl(Inline)]
        AsmFunctionGroup(OpIdentity id, AsmFunction[] members)
        {
            this.Id = id;
            this.Members = members;            
        }

        public readonly OpIdentity Id;

        public readonly AsmFunction[] Members;

        public override string ToString() 
            => Id;
    }
}