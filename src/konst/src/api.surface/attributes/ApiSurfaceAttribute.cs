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

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class ApiSurfaceAttribute : ApiHostAttribute
    {
        public string SurfaceName {get;}

        public ushort SurfaceKey {get;}

        public ApiSurfaceAttribute()
        {
            SurfaceName = EmptyString;
            SurfaceKey = 0;
        }

        public ApiSurfaceAttribute(string name)
            : base(name)
        {
            SurfaceName = name;
            SurfaceKey = 0;
        }

        public ApiSurfaceAttribute(string name, ushort key)
            : base(name)
        {
            SurfaceName = name;
            SurfaceKey = key;
        }

        public ApiSurfaceAttribute(ushort key)
        {
            SurfaceName = EmptyString;
            SurfaceKey = key;
        }
    }
}