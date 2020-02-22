//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Root;

    public static class AssemblyDesignator
    {
        public static IAssemblyDesignator Empty => new EmptyDesignator();

        /// <summary>
        /// Returns a useful assembly designator where one can be found; otherwise, returns the empty designator
        /// </summary>
        /// <param name="a">The assembly to query</param>
        public static IAssemblyDesignator Designator(this Assembly a)
            => a.GetDesignator();

        /// <summary>
        /// Returns the assigned assembly id which either identifies an acutal assebmly or is none/empty
        /// </summary>
        /// <param name="a">The assembly to query</param>
        [MethodImpl(Inline)]
        public static AssemblyId AssemblyId(this Assembly a)
            => a.GetAssemblyId();

        public static IEnumerable<IAssemblyDesignator> Designates(this Assembly a)
            => a.Designator().Designates;

        public static IEnumerable<ApiHost> ApiHosts(this Assembly src)
            => from t in src.GetTypes()
                where t.Attributed<ApiHostAttribute>()
                select ApiHost.Define(t);
        
        [MethodImpl(Inline)]
        static AssemblyId GetAssemblyId(this Assembly src)
            => Identifiers.GetOrAdd(src, a => a.GetDesignator().Id);

        static Type FindDesignator(Assembly a)
            => a.GetTypes().Where(x => !x.Ignore() && !x.IsAbstract && x.GetInterfaces().Contains(typeof(IAssemblyDesignator))).FirstOrDefault();

        static IAssemblyDesignator GetDesignator(this Assembly a)
        {
            static IAssemblyDesignator factory(Assembly a)
            {                
                try
                {
                    var t = FindDesignator(a);
                    if(t != null)
                    {
                        var designator = Activator.CreateInstance(t) as IAssemblyDesignator;
                        if(designator != null)
                            return designator;   
                    }
                    return AssemblyDesignator.Empty;            
                }
                catch(Exception)
                {
                    return AssemblyDesignator.Empty;            
                }
            }
            
            return Designators.GetOrAdd(a,factory);
        }

        static ConcurrentDictionary<Assembly,IAssemblyDesignator> Designators
            = new ConcurrentDictionary<Assembly, IAssemblyDesignator>();            

        static ConcurrentDictionary<Assembly,AssemblyId> Identifiers
            = new ConcurrentDictionary<Assembly, AssemblyId>();            

    }
}