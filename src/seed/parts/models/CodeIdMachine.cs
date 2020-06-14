//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Alternate identity indidators for use in source code identifier production
    /// </summary>
    readonly struct CodeIdMachine : ILegalIdentityMachine
    {
        public static CodeIdMachine Service 
            => default(CodeIdMachine);
                
        [MethodImpl(Inline)]
        public string Manufacture(OpIdentity src)
            => LegalIdentityMachine.Service(this).Manufacture(src);
        
        public char TypeArgsOpen => SymNot.Lt;

        public char TypeArgsClose => SymNot.Gt;

        public char ArgsOpen => SymNot.Circle;

        public char ArgsClose => SymNot.Circle;

        public char ArgSep => SymNot.Dot;
    }
}