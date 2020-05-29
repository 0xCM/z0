//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Symbolic;

    using UP = AsciLetterUp;
    using LO = AsciLetterLo;

    public partial class SymTest
    {
        [MethodImpl(Inline), Op]
        public static bool IsLetter(UpperCased @case, char c)
            => (ushort)c >= (ushort)UP.First  && (ushort)c <= (ushort)UP.Last;

        [MethodImpl(Inline), Op]
        public static bool IsLetter(LowerCased @case, char c)
            => (ushort)c >= (ushort)LO.First  && (ushort)c <= (ushort)LO.Last;

        [MethodImpl(Inline), Op]
        public static bool IsLetter(char c)
            => IsLetter(UpperCase, c) || IsLetter(LowerCase, c);
    }
}