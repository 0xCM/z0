//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct OpCodes
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OpCode<K> opcode<K>(Label name, OpCodeTable table, Hex16 op)
            where K : unmanaged
        {
            var encoded = (uint)table |(uint)op <<8;
            return new OpCode<K>(name, @as<uint,K>(encoded));
        }

        [MethodImpl(Inline), Op]
        public static OpCode opcode(Label name, OpCodeTable table, Hex16 op)
        {
            var encoded = (uint)table |(uint)op <<8;
            return new OpCode(name, encoded);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Hex16 value<K>(OpCode<K> src)
            where K : unmanaged
                => (ushort)(u32(src.Data) >> 8);

        [MethodImpl(Inline), Op]
        public static Hex16 value(OpCode src)
            => (ushort)(u32(src.Data) >> 8);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OpCodeTable table<K>(OpCode<K> src)
            where K : unmanaged
                => u8(src.Data);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OpCode untype<K>(OpCode<K> src)
            where K : unmanaged
                => new OpCode(src.Name, u32(src.Data));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static OpCodeTable table(OpCode src)
            => u8(src.Data);

        public static string format(OpCode src)
        {
            var val = value(src).Format();
            var tbl = src.Table;
            var name = src.Name;
            return string.Format("{0} {1} {2}:{3}",name, (char)LogicSym.Def, tbl, val);
        }
    }
}