//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct OpCodeIdentity
    {        
        public static OpCodeIdentity Service => default;
        
        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public OpCodeIdentifier Compute(in OpCodeRecord src)
        {
            //var part1 = MnemonicPart(src);
            return new OpCodeIdentifier(src.Expression);
        }

        [MethodImpl(Inline), Op]
        public void Compute(ReadOnlySpan<OpCodeRecord> src, Span<OpCodeIdentifier> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = Compute(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        string MnemonicPart(in OpCodeRecord record)
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