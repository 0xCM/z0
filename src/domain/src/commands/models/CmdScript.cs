//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct CmdScript : ITextual
    {
        readonly TableSpan<CmdExpr> Data;

        [MethodImpl(Inline)]
        public CmdScript(CmdExpr[] src)
        {
            Data = src;
        }

        public Span<CmdExpr> Parts
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref CmdExpr First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public uint PartCount
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdScript(CmdExpr[] src)
            => new CmdScript(src);

        public string Format()
        {
            var dst = text.build();
            var count = PartCount;
            var parts = Data.View;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(parts,i).Format());
            return dst.ToString();
        }

        public override string ToString()
            => Format();
    }
}