//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Reflection;

    using static Root;
    using static core;

    public class ApiTypeCatalog : AppService<ApiTypeCatalog>
    {
        Index<LiteralProvider> _LiteralProviders;

        ConcurrentDictionary<Type,Index<ProvidedLiteral>> _ProvidedLiterals;

        readonly object _LiteralProviderLocker;

        public ApiTypeCatalog()
        {
            _LiteralProviders = new();
            _ProvidedLiterals = new();
            _LiteralProviderLocker = new();
        }

        public ReadOnlySpan<LiteralProvider> LiteralProviders()
        {
            lock(_LiteralProviderLocker)
            {
                if(_LiteralProviders.IsEmpty)
                {
                    _LiteralProviders = ClrLiterals.providers(Wf.ApiCatalog.Components);
                }
            }
            return _LiteralProviders.View;
        }

        public ReadOnlySpan<ProvidedLiteral> Literals(LiteralProvider src)
            => _ProvidedLiterals.GetOrAdd(src.Definition, t => ClrLiterals.provided(src));
    }
}