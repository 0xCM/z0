//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    [ApiHost(ApiNames.ApiQuery, true)]
    public partial class ApiQuery : AppService<ApiQuery>
    {
        const NumericKind Closure = UnsignedInts;

        Index<IApiKind> Kinds;

        Index<ApiClassifier> _ApiClasses;

        Index<SymLiteral> _ApiClassLiterals;

        object locker;

        public ApiQuery()
        {
            Kinds = Index<IApiKind>.Empty;
            locker = new object();
        }

        public ReadOnlySpan<IApiKind> ApiKinds()
        {
            lock(locker)
            {
                if(Kinds.IsEmpty)
                    Kinds = kinds();
            }
            return Kinds.View;
        }

        public ReadOnlySpan<SymLiteral> ApiClassLiterals()
        {
            lock(locker)
            {
                if(_ApiClassLiterals.IsEmpty)
                    _ApiClassLiterals = ClassLiterals();
            }
            return _ApiClassLiterals.View;
        }

        public ReadOnlySpan<ApiClassifier> ApiClassifiers()
        {
            lock(locker)
            {
                if(_ApiClasses.IsEmpty)
                    _ApiClasses = Classifiers();
            }
            return _ApiClasses.View;
        }

        [Op]
        public static MethodInfo[] methods(in ApiRuntimeType src, HashSet<string> exclusions)
            => src.HostType.DeclaredMethods().Unignored().NonGeneric().Exclude(exclusions);

        [Op]
        public static ApiHostInfo hostinfo(Type t)
        {
            var methods = t.DeclaredMethods();
            return new ApiHostInfo(t, t.HostUri(), t.Assembly.Id(), methods, index(methods));
        }

        [Op]
        public static ApiHostInfo hostinfo<T>()
            => hostinfo(typeof(T));

        /// <summary>
        /// Searches an assembly for types tagged with the <see cref="FunctionalServiceAttribute"/>
        /// </summary>
        /// <param name="src">The assembly to search</param>
        [Op]
        public static Type[] svchosts(Assembly src)
            => src.GetTypes().Where(t => t.Tagged<FunctionalServiceAttribute>());

        [Op]
        static Dictionary<string,MethodInfo> index(Index<MethodInfo> methods)
        {
            var index = new Dictionary<string, MethodInfo>();
            root.iter(methods, m => index.TryAdd(ApiIdentity.identify(m).IdentityText, m));
            return index;
        }
    }
}