//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    using api = Rules;

    partial struct Rules
    {
        public class Grammar
        {
            public Label Name {get;}

            List<IProduction> _Productions;

            public Grammar(Label name)
            {
                Name = name;
                _Productions = new();
            }

            public P Add<P>(P src)
                where P : IProduction
            {
                _Productions.Add(src);
                return src;
            }

            public IReadOnlyList<IProduction> Productions
                => _Productions;

            public string Format()
                => api.format(this);

            public override string ToString()
                => Format();
        }
    }
}