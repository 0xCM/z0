//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using K = SymSpecKind;
    using S = SymSpec;

    [ApiHost]
    public readonly struct SymSpecs
    {
        [Op]
        public static SymSpecKind kind(ReadOnlySpan<string> names)
        {
            const string IndexField = nameof(S.Index);
            const string KindField = nameof(S.Kind);
            const string NameField = nameof(S.Name);
            const string ExpressionField = nameof(S.Expression);
            const string ValueField = nameof(S.Value);
            const string DescriptionField = nameof(S.Description);
            const string ValueKindField = nameof(S.ValueKind);
            var result = SymSpecKind.None;
            for(var i=0; i<names.Length; i++)
            {
                ref readonly var name = ref skip(names, i);
                if(text.equals(name, IndexField))
                    result |= K.Index;
                else if(text.equals(name, KindField))
                    result |= K.Kind;
                else if(text.equals(name, NameField))
                    result |= K.Name;
                else if(text.equals(name, ExpressionField))
                    result |= K.Expression;
                else if(text.equals(name, ValueField))
                    result |= K.Value;
                else if(text.equals(name, DescriptionField))
                    result |= K.Description;
                else if(text.equals(name, ValueKindField))
                    result |= K.Kind;
            }

            return result;
        }
    }
}