//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct AsmFunctionList : IEquatable<AsmFunctionList>, IIndex<AsmFunction>
    {                        
        public AsmFunction[] Content {get;}

        [MethodImpl(Inline)]
        public static AsmFunctionList Define(params AsmFunction[] src)
            => new AsmFunctionList(src);

        [MethodImpl(Inline)]
        public AsmFunctionList(AsmFunction[] src)
            => Content = src;        

        bool IEquatable<AsmFunctionList>.Equals(AsmFunctionList src)
            => Enumerable.SequenceEqual(this, src);

        public static AsmFunctionList Empty 
            => new AsmFunctionList(Array.Empty<AsmFunction>());
    }
}