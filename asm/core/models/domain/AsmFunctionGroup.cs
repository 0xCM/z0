//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static root;

    /// <summary>
    /// Defines a group of related assembly functions
    /// </summary>
    public readonly struct AsmFunctionGroup
    {        
        public static AsmFunctionGroup Define(OpIdentity id, AsmFunction[] members)
        {            
            if(members.Length == 0)
                AppErrors.ThrowFeatureUnsupported($"{id}: Empty groups are disallowed");            
            
            return new AsmFunctionGroup(id, members);
        }

        public static AsmFunctionGroup Define(GenericOpIdentity id, AsmFunction[] members)
            => Define(id.Generialize(), members);

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