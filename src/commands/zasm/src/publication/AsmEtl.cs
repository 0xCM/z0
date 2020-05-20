//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using M = AsmDataModels;

    public interface IAsmEtl : IService, IAsmArchiveConfig
    {
        void Publish();
    }

    public partial class AsmEtl : IAsmEtl
    {
        public static AsmEtl Service => new AsmEtl();

        public static M.OpCodeForms OpCodeForms 
            => M.OpCodeForms.Model;

        public static M.Instructions Instructions 
            => M.Instructions.Model;
    }
}