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

        public ResDescriptor Asset(ContentName id)
        {
            if(Resources.descriptor(DataSource, id, out ResDescriptor res))
                return res;
            else
            {
                var msg = string.Format("The assembly {0}, loaded from {1}, does not contain a resource with identifier {2}", DataSource.GetSimpleName(), FS.path(DataSource.Location).ToUri(), id);
                throw new Exception(msg);
            }
        }

        public ResDescriptors All()
            => Resources.descriptors(DataSource);
    }
}