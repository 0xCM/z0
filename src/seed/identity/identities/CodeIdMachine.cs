//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Alternate identity indidators for use in source code identifier production
    /// </summary>
    readonly struct CodeIdMachine : ILegalIdentityMachine
    {
        public static ILegalIdentityMachine Service => default(CodeIdMachine);

        public char TypeArgsOpen => SymNot.Lt;

        public char TypeArgsClose => SymNot.Gt;

        public char ArgsOpen => SymNot.Circle;

        public char ArgsClose => SymNot.Circle;

        public char ArgSep => SymNot.Dot;
    }

}