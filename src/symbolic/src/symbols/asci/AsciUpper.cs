//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static Letters;

    public sealed class AsciUpper : SymbolSet<AsciUpper, AsciAlphabet>
    {        
        public static Symbol<AsciAlphabet>[] All
            => _Symbols;

        static AsciUpper()
        {
            _Symbols = new Symbol<AsciAlphabet>[]{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z};            
        }
   }
}