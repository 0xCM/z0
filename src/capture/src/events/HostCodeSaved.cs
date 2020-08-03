//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    public readonly struct UriCodeSaved : IWfEvent<UriCodeSaved>
    {
        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;
        
        public readonly MemberCode[] Code;

        public readonly FilePath Target;
        
        [MethodImpl(Inline)]
        public UriCodeSaved(ApiHostUri host, MemberCode[] code, FilePath dst)
        {
            Host = host;
            Code = code;
            Target = dst;
        }
        
        public string Format()
            => $"{Code.Length} {Host} functions saved to {Target}";
            
        public UriCodeSaved Zero 
            => Empty;            

        public static UriCodeSaved Empty 
            => new UriCodeSaved(ApiHostUri.Empty, Array.Empty<MemberCode>(), FilePath.Empty);
    }    

}