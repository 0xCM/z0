//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct OpCodes
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OpCode<K> opcode<K>(Label name, Domain table, Hex16 op)
            where K : unmanaged
        {
            var encoded = (ulong)table |(ulong)op <<16;
            return new OpCode<K>(name, @as<ulong,K>(encoded));
        }

        [MethodImpl(Inline), Op]
        public static OpCode opcode(Label name, Domain table, Hex16 op)
        {
            var encoded = (ulong)table |(ulong)op <<16;
            return new OpCode(name, encoded);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Hex64 value<K>(OpCode<K> src)
            where K : unmanaged
                => (bw64(src.Data) >> 16);

        [MethodImpl(Inline), Op]
        public static Hex64 value(OpCode src)
            => src.Data >> 16;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Domain domain<K>(OpCode<K> src)
            where K : unmanaged
                => bw16(src.Data);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OpCode untype<K>(OpCode<K> src)
            where K : unmanaged
                => new OpCode(src.Name, bw64(src.Data));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Domain domain(OpCode src)
            => u16(src.Data);

        public static string format(OpCode src)
        {
            var val = value(src).Format();
            var tbl = src.Domain;
            var name = src.Name;
            return string.Format("{0} {1} {2}:{3}",name, (char)LogicSym.Def, tbl, val);
        }
    }
}