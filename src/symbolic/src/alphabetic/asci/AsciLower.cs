//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static AsciLetterLo;

    public class AsciLower : SymbolSet<AsciLower, AsciAlphabet>
    {
        static AsciLower()
            => _Symbols = new Symbol<AsciAlphabet>[]{a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z};    
    }
}