//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public enum OpUriScheme
    {
        None = 0,
        
        Asm,

        Hex,

        Raw,

        Cil

    }

    public static class OpUriSchemeOps
    {
        public static string Format(this OpUriScheme src)
            => src.ToString().ToLower();
        
        public static OpUriScheme Parse(string text)        
            => Enum.TryParse(typeof(OpUriScheme), text, true, out var result) 
               ? (OpUriScheme)result 
               : OpUriScheme.None;
    }
}