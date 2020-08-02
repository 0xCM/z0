//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HexCodeSaved : IWfEvent<HexCodeSaved>
    {
        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;
        
        public readonly IdentifiedCode[] Code;

        public readonly FilePath Target;
        
        [MethodImpl(Inline)]
        public HexCodeSaved(ApiHostUri host, IdentifiedCode[] code, FilePath dst)
        {
            Host = host;
            Code = code;
            Target = dst;
        }
        
        public string Format()
            => $"{Code.Length} {Host} functions saved to {Target}";
        
        public HexCodeSaved Zero 
            => Empty;            

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;

        public static HexCodeSaved Empty 
            => new HexCodeSaved(ApiHostUri.Empty, Array.Empty<IdentifiedCode>(), FilePath.Empty);
    }    
}