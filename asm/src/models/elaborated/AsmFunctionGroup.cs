//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.AsmSpecs;

    using static zfunc;

    /// <summary>
    /// Defines a group of related assembly functions
    /// </summary>
    public readonly struct AsmFunctionGroup
    {
        public static AsmFunctionGroup Define(Moniker id, AsmFunction[] members)
        {            
            if(members.Length == 0)
                throw error(appMsg($"{id}: Empty groups are disallowed"));            
            return new AsmFunctionGroup(id, members);
        }
        
        AsmFunctionGroup(Moniker id, AsmFunction[] members)
        {
            this.Id = id;
            this.Members = members;            
        }
        
        public readonly Moniker Id;

        public readonly AsmFunction[] Members;
    }

}