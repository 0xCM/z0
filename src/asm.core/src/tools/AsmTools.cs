//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public partial class AsmTools : Service<AsmTools>
    {
        Symbols<AsmToolKind> _Assemblers;

        Symbols<AsmFileKind> _FileKinds;

        public AsmTools()
        {
            _Assemblers = Symbols.index<AsmToolKind>();
            _FileKinds = Symbols.index<AsmFileKind>();
        }

        protected override void Initialized()
        {

        }

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Sym<AsmToolKind>> Tools()
            => slice(_Assemblers.View,1);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<Sym<AsmFileKind>> FileKinds()
            => slice(_FileKinds.View,1);
    }
}