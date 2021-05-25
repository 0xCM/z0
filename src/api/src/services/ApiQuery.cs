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

    using static Root;

    [ApiHost]
    public partial class ApiQuery : AppService<ApiQuery>
    {
        const NumericKind Closure = UnsignedInts;

        Index<IApiClass> _Classes;

        Index<ApiClassifier> _Classifiers;

        Index<SymLiteral> _ClassLiterals;

        object locker;

        public ApiQuery()
        {
            _Classes = Index<IApiClass>.Empty;
            locker = new object();
        }

        public ReadOnlySpan<IApiClass> ApiKinds()
        {
            lock(locker)
            {
                if(_Classes.IsEmpty)
                    _Classes = kinds();
            }
            return _Classes.View;
        }

        public ReadOnlySpan<SymLiteral> ApiClassLiterals()
        {
            lock(locker)
            {
                if(_ClassLiterals.IsEmpty)
                    _ClassLiterals = ClassLiterals();
            }
            return _ClassLiterals.View;
        }

        public ReadOnlySpan<ApiClassifier> ApiClassifiers()
        {
            lock(locker)
            {
                if(_Classifiers.IsEmpty)
                    _Classifiers = Classifiers();
            }
            return _Classifiers.View;
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