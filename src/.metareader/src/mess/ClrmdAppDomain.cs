//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MS
{
    using System;
    using System.Collections.Immutable;

    using Z0.Dac;    

    public class ClrmdAppDomain : ClrAppDomain
    {
        private readonly IAppDomainHelpers _helpers;

        public override ClrRuntime Runtime { get; }
        
        public override ulong Address { get; }
        
        public override int Id { get; }
        
        public override string? Name { get; }
        
        public override ImmutableArray<ClrModule> Modules { get; }
        
        public override string? ConfigurationFile 
            => _helpers.GetConfigFile(this);
        
        public override string? ApplicationBase 
            => _helpers.GetApplicationBase(this);

        public ClrmdAppDomain(ClrRuntime runtime, IAppDomainData data)
        {
            if (data is null)
                throw new ArgumentNullException(nameof(data));

            _helpers = data.Helpers;
            Runtime = runtime;
            Id = data.Id;
            Address = data.Address;
            Name = data.Name;
            Runtime = runtime;
            Modules = _helpers.EnumerateModules(this).ToImmutableArray();
        }

        /// <summary>
        /// Create an "empty" ClrAppDomain when we cannot request app domain details.
        /// </summary>
        /// <param name="runtime">The contianing runtime.</param>
        /// <param name="helpers">Helpers for quering data</param>
        /// <param name="address">The address of the AppDomain</param>
        public ClrmdAppDomain(ClrRuntime runtime, IAppDomainHelpers helpers, ulong address)
        {
            if (runtime is null)
                throw new ArgumentNullException(nameof(runtime));

            if (helpers is null)
                throw new ArgumentNullException(nameof(helpers));

            Runtime = runtime;
            _helpers = helpers;
            Address = address;
            Id = -1;
            Modules = _helpers.EnumerateModules(this).ToImmutableArray();
        }
    }
}