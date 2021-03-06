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

    partial struct Rules
    {
        public static Index<RuleOperand> operands<T>(T src)
            where T : struct, IRule<T>
        {
            var props = @readonly(typeof(T).DeclaredInstanceProperties());
            var _ref = __makeref(src);
            var count = props.Length;
            var buffer = alloc<RuleOperand>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var prop = ref skip(props,i);
                seek(dst,i) = new RuleOperand(prop.Name, prop.GetValue(src));
            }
            return buffer;
        }
    }
}