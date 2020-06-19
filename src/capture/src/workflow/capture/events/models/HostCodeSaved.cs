//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct UriCodeSaved : IAppEvent<UriCodeSaved>
    {
        public readonly ApiHostUri Host;
        
        public readonly UriCode[] Code;

        public readonly FilePath Target;
        
        [MethodImpl(Inline)]
        public UriCodeSaved(ApiHostUri host, UriCode[] code, FilePath dst)
        {
            Host = host;
            Code = code;
            Target = dst;
        }
        
        public string Description
            => $"{Code.Length} {Host} functions saved to {Target}";
            
        public UriCodeSaved Zero 
            => Empty;            

        public static UriCodeSaved Empty 
            => new UriCodeSaved(ApiHostUri.Empty, Array.Empty<UriCode>(), FilePath.Empty);
    }    

}