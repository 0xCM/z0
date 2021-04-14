//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public abstract class Assets<T> : IAssets
        where T : Assets<T>, new()
    {
        public static T create()
            => new T();

        public Assembly DataSource
            => typeof(T).Assembly;

        ResDescriptors _Descriptors;

        protected Assets()
        {
            _Descriptors = ResDescriptors.from(DataSource);
        }

        public ref readonly ResDescriptor Asset(ResourceName id)
        {
            var matches = _Descriptors.Filter(id);
            if(matches.ResourceCount == 0)
            {
                var msg = string.Format("The assembly {0}, loaded from {1}, does not contain a resource with identifier {2}", DataSource.GetSimpleName(), DataSource.Location, id);
                root.@throw(msg);
            }

            return ref matches[0];
        }

        public ResDescriptors Descriptors
            => _Descriptors;
    }
}