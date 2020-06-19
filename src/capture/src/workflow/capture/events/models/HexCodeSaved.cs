//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexCodeSaved : IAppEvent<HexCodeSaved>
    {
        public readonly ApiHostUri Host;
        
        public readonly UriHex[] Code;

        public readonly FilePath Target;
        
        [MethodImpl(Inline)]
        public HexCodeSaved(ApiHostUri host, UriHex[] code, FilePath dst)
        {
            Host = host;
            Code = code;
            Target = dst;
        }
        
        public string Description
            => $"{Code.Length} {Host} functions saved to {Target}";
        
        public HexCodeSaved Zero 
            => Empty;            

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;

        public static HexCodeSaved Empty 
            => new HexCodeSaved(ApiHostUri.Empty, Array.Empty<UriHex>(), FilePath.Empty);
    }    
}