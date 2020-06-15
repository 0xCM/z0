//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    public readonly struct OpCodeIdentity
    {        
        public static OpCodeIdentity Service => default;
        
        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public OpCodeIdentifier Compute(in CommandInfo src)
            => new OpCodeIdentifier(src.OpCode);

        [MethodImpl(Inline), Op]
        public void Compute(ReadOnlySpan<CommandInfo> src, Span<OpCodeIdentifier> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = Compute(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        string MnemonicPart(in CommandInfo record)
        {
            var length = record.Mnemonic.Length;
            ReadOnlySpan<char> src = record.Mnemonic;
            Span<char> dst = stackalloc char[length];
            head(dst) = head(src);
            for(var i=1; i<length; i++)
                seek(dst,i) = Symbolic.lowercase(skip(src,i));
            return new string(src);
        }
    }
}