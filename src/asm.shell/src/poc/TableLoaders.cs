//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;
    using static WsAtoms;

    using  L = ApiLiterals;

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
            var dst = Ws.Tables().Table(machine, "api.literals");
            for(var i=0; i<count; i++)
            {
                ref readonly var provider = ref skip(providers,i);
                var literals = L.provided(provider).View;
                for(var j=0; j<literals.Length; j++)
                    buffer.Add(skip(literals,j).Specify());
            }

            var records = buffer.ToArray();
            TableEmit(records.ToReadOnlySpan(), CompilationLiteral.RenderWidths, dst);
            return records;
        }
    }
}