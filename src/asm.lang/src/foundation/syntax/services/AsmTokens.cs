//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public class AsmTokens : WfService<AsmTokens>
    {
        Symbols<AsmPrefixToken> _Prefixes;

        [MethodImpl(NotInline), Op]
        void LoadPrefixes()
        {
            _Prefixes = Symbols.load<AsmPrefixToken>();
        }

        [Op]
        public Symbols<AsmPrefixToken> Prefixes()
        {
            if(_Prefixes.IsEmpty)
                LoadPrefixes();
            return _Prefixes;
        }
    }
}