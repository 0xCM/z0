//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;
    
    public readonly struct Tabular<F,R> : ITabular<F,Tabular<F,R>>
        where F : unmanaged, Enum
        where R : ITabular
    {
        readonly R Data;
        
        public FieldValue<F>[] FieldValues {get;}

        public string[] HeaderNames 
            => Tabular.headers<F>();
        
        public int FieldCount 
            => FieldValues.Length;

        [MethodImpl(Inline)]
        public Tabular(R data)
        {
            Data = data;

            var props = typeof(R).Properties().Select(p => (p.Name, p)).ToDictionary();
            var fields = Tabular.fields<F>();
            var values = new List<FieldValue<F>>();
            for(var i=0; i<fields.Length; i++)
            {
                var field = fields[i];
                var name = field.ToString();
                if(props.TryGetValue(name, out var prop))
                    values.Add(new FieldValue<F>(field, Null.Banish(prop.GetValue(data))));
            }
            
            FieldValues = values.ToArray();
        }
        
        public string DelimitedText(char sep)
            => string.Empty;
    }
}