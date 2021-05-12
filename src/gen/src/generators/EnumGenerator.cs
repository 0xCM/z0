//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static memory;

    public struct EnumSpec
    {
        public Identifier Name;

        public ClrEnumKind DataType;

        public bool Flags;

        public TextBlock Description;

        public Index<Identifier> Names;

        public Index<ulong> Values;

        public Index<string> Descriptions;

        public Index<string> Symbols;
    }

    public class EnumGenerator : CodeGenerator<EnumSpec>
    {
        public override void Generate(in EnumSpec spec, ITextBuffer dst)
        {
            var kw = NumericKinds.kind(spec.DataType).Keyword();
            var counter = 0ul;
            var names = spec.Names.View;
            var count = names.Length;
            var values = spec.Values.View;

            if(spec.Flags)
                dst.AppendLine("[Flags]");
            dst.AppendFormat("public enum {0} : {1}", spec.Name, kw);
            dst.AppendLine("{");
            for(var i=0; i<count; i++)
            {
                var name = skip(names,i);
                var value = values.Length != 0 ? skip(values,i) : counter++;
                dst.AppendLineFormat("    {0} = {1}", name, value);
            }
            dst.AppendLine("}");
        }
    }
}
