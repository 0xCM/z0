//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsmFxGroup : ISymbolic<AsmFxGroup,asci16>
    {        
        public asci16 Body {get;}

        [MethodImpl(Inline)]
        public AsmFxGroup(string name)
            => Body = asci.encode(n16, name);

        [MethodImpl(Inline)]
        public AsmFxGroup(asci16 name)
            => Body = name;
    
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Body.IsEmpty;
        }
        
        public AsmFxGroup Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }
        
        public bool Equals(AsmFxGroup src)
            => Body.Equals(src.Body);
        
        [MethodImpl(Inline)]
        public string Format()
            => Body.Format();

        public static AsmFxGroup Empty 
            => new AsmFxGroup(asci16.Null);
    }
}