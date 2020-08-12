//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Format
    {   
        public static IFormatter formatter(object src)
        {
            var attrib = src?.GetType()?.GetCustomAttribute<FormatterAttribute>();
            if(attrib != null)
                return formatter(attrib.Realization);
            else
                return DefaultFormatter.Service;
        }

        public static IFormatter formatter(Type host)
        {
            try
            {
                return (IFormatter)Activator.CreateInstance(host);
            }
            catch(Exception)
            {
                return DefaultFormatter.Service;
            }
        }        
    }
}