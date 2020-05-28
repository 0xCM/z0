//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ILetter : ITextual
    {
        AsciLetter Symbol {get;}        

        AsciLetterCode Code
             => (AsciLetterCode)Symbol;

        char Character
             => (char)Symbol;

        string ITextual.Format()
            => Character.ToString();
    }

    public interface ILetter<L> : ILetter, IEquatable<L>
        where L : unmanaged, ILetter<L>
    {

    }
}