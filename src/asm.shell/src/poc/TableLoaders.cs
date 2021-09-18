//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using L = ApiLiterals;

    public class TableLoaders : AppService<TableLoaders>
    {
        public TableLoaders()
        {

        }

        public Index<CompilationLiteral> ApiLiterals()
        {
            var result = Outcome.Success;
            var components = ApiRuntimeLoader.assemblies();
            var providers = L.providers(components).View;
            var count = providers.Length;
            var buffer = list<CompilationLiteral>();
            for(var i=0; i<count; i++)
            {
                ref readonly var provider = ref skip(providers,i);
                var literals = L.provided(provider).View;
                for(var j=0; j<literals.Length; j++)
                    buffer.Add(skip(literals,j).Specify());
            }

            return buffer.ToArray();
        }
    }
}