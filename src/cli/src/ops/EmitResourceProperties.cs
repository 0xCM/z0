//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static z;

    partial struct Cil
    {
        public static void EmitResourceProperties(EmitCilCmd cmd)
        {
            var summary = cmd.SummaryTarget.Writer();
            var header = text.concat("Type".PadRight(20), "| ", "Property".PadRight(30), "| ", "Cil Bytes");
            summary.WriteLine(header);

            var types = array(typeof(HexCharData), typeof(KonstBytes));
            var mod = types[0].Module;
            var props = types.StaticProperties().Where(p => p.GetGetMethod() != null && p.PropertyType == typeof(ReadOnlySpan<byte>));

            foreach(var p in props)
            {
                var m = p.GetGetMethod();
                var body = m.GetMethodBody();
                var cil = body.GetILAsByteArray();
                var line = string.Concat(m.DeclaringType.Name.PadRight(20), "| ", m.Name.PadRight(30), "| ", cil.FormatHexBytes());
                summary.WriteLine(line);
            }

            var decoded = Cil.decode(mod, props.Select(x => x.GetGetMethod())).ToArray();
            var writer = new FunctionWriter(cmd.CilTarget);
            writer.Write(decoded);
        }
    }
}