//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    public readonly struct AsmCommandGroup : ISymbolic<AsmCommandGroup,asci16>
    {        
        public asci16 Body {get;}

        [MethodImpl(Inline)]
        public AsmCommandGroup(string name)
        {
            Body = asci.encode(n16, name);
        }

        [MethodImpl(Inline)]
        public AsmCommandGroup(asci16 name)
        {
            Body = name;
        }
    
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Body.IsEmpty;
        }
        
        public AsmCommandGroup Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }
        
        public bool Equals(AsmCommandGroup src)
            => Body.Equals(src.Body);
        
        [MethodImpl(Inline)]
        public string Format()
            => Body.Format();

        public static AsmCommandGroup Empty 
            => new AsmCommandGroup(asci16.Null);

    }
}