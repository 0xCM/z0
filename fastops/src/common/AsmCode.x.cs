//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class AsmCodeExtensions
    {
        /// <summary>
        /// Loads native code into the buffer for execution
        /// </summary>
        /// <param name="src">The source code (pun intended)</param>
        [MethodImpl(Inline)]
        public static ExecBufferToken Load(this ExecBufferToken buffer, in AsmCode src)
        {
            buffer.Fill(src.Encoded);
            return buffer;
        }

        [MethodImpl(Inline)]
        public static AsmCode WithIdentity(this AsmCode src, OpIdentity id)
            => AsmCode.Define(id, src.Origin, src.Label, src.Encoded);

        public static bool AcceptsParameter(this AsmCode src, NumericKind kind)
            => Numeric.kinds(src.Id.TextComponents.Skip(1)).Contains(kind);

        [MethodImpl(Inline)]
        public static int ParameterCount(this AsmCode src)
            => src.Id.TextComponents.Count() - 1;

        public static IEnumerable<AsmCode> AcceptsParameter(this IEnumerable<AsmCode> src, NumericKind kind)
            => from code in src
                where code.AcceptsParameter(kind)
                select code;
                    
        public static IEnumerable<AsmCode> AcceptsParameters(this IEnumerable<AsmCode> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = Numeric.kinds(code.Id.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        public static IEnumerable<AsmCode> HasParameterCount(this IEnumerable<AsmCode> src, int count)
            => from code in src
                where code.ParameterCount() == count
                select code;
    }
}