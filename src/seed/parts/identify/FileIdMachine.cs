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
    readonly struct FileIdMachine : ILegalIdentityMachine
    {
        public static FileIdMachine Service => default(FileIdMachine);

        [MethodImpl(Inline)]
        public string Manufacture(OpIdentity src)
            => LegalIdentityMachine.Service(this).Manufacture(src);

        public char TypeArgsOpen => Chars.LBracket;

        public char TypeArgsClose => Chars.RBracket;

        public char ArgsOpen => Chars.LParen;

        public char ArgsClose => Chars.RParen;

        public char ArgSep => Chars.Comma;
    }
}